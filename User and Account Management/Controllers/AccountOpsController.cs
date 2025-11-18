using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using User_and_Account_Management.Models;

namespace User_and_Account_Management.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class AccountOpsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AccountOpsController(AppDbContext context)
        {
            _context = context;
        }

        // ----------------------------
        // LIST accounts (user: own accounts, admin can pass userId)
        // ----------------------------
        [HttpGet]
        public async Task<IActionResult> GetAccounts([FromQuery] AccountListQueryDto q)
        {
            var query = _context.Accounts
                .Include(a => a.AccountType)
                .Include(a => a.Currency)
                .Include(a => a.Branch).ThenInclude(b => b.Bank)
                .Include(a => a.User)
                .AsQueryable();

            // If not admin, restrict to current user
            var isAdmin = User.IsInRole("Admin") || User.IsInRole("SYSAdmin") || User.IsInRole("ManagerUser");
            if (!isAdmin)
            {
                var currentUserId = int.Parse(User.FindFirst("UserID").Value);
                query = query.Where(a => a.UserID == currentUserId);
            }
            else
            {
                if (q.UserId.HasValue)
                    query = query.Where(a => a.UserID == q.UserId.Value);
            }

            // Search q
            if (!string.IsNullOrWhiteSpace(q.Search))
            {
                var s = q.Search.Trim();
                query = query.Where(a =>
                    a.AccountNumber.Contains(s) ||
                    a.User.Username.Contains(s) ||
                    a.Branch.BranchName.Contains(s) ||
                    a.Branch.Bank.BankName.Contains(s));
            }

            // Sort
            if (!string.IsNullOrWhiteSpace(q.Sort))
            {
                // expected format: "Balance:desc" or "AccountNumber:asc"
                var parts = q.Sort.Split(':');
                var key = parts[0].ToLower();
                var dir = parts.Length > 1 ? parts[1].ToLower() : "asc";

                query = key switch
                {
                    "balance" => dir == "desc" ? query.OrderByDescending(a => a.Balance) : query.OrderBy(a => a.Balance),
                    "accountnumber" => dir == "desc" ? query.OrderByDescending(a => a.AccountNumber) : query.OrderBy(a => a.AccountNumber),
                    "opendate" => dir == "desc" ? query.OrderByDescending(a => a.OpenDate) : query.OrderBy(a => a.OpenDate),
                    _ => query.OrderBy(a => a.AccountID)
                };
            }
            else
            {
                query = query.OrderBy(a => a.AccountID);
            }

            // Pagination
            var page = q.Page <= 0 ? 1 : q.Page;
            var pageSize = q.PageSize <= 0 ? 20 : q.PageSize;
            var total = await query.CountAsync();

            var items = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(a => new
                {
                    a.AccountID,
                    a.AccountNumber,
                    a.Balance,
                    Currency = a.CurrencyCode,
                    AccountType = a.AccountType.TypeName,
                    Bank = a.Branch.Bank.BankName,
                    Branch = a.Branch.BranchName,
                    a.IsActive,
                    a.OpenDate,
                    a.CloseDate,
                    a.UserID,
                    Username = a.User.Username
                })
                .ToListAsync();

            return Ok(new { items, total, page, pageSize });
        }

        // ----------------------------
        // CREATE account (Admin / SYSAdmin)
        // ----------------------------
        [HttpPost]
        [Authorize(Roles = "Admin,SYSAdmin")]
        public async Task<IActionResult> CreateAccount([FromBody] CreateAccountDto dto)
        {
            if (!await _context.Users.AnyAsync(u => u.UserID == dto.UserID))
                return BadRequest("Invalid user id.");

            if (!await _context.Branches.AnyAsync(b => b.BranchID == dto.BranchID))
                return BadRequest("Invalid branch id.");

            if (!await _context.AccountTypes.AnyAsync(t => t.AccountTypeID == dto.AccountTypeID))
                return BadRequest("Invalid account type id.");

            if (!await _context.Currencies.AnyAsync(c => c.CurrencyCode == dto.CurrencyCode))
                return BadRequest("Invalid currency code.");

            var account = new Account
            {
                UserID = dto.UserID,
                BranchID = dto.BranchID,
                AccountTypeID = dto.AccountTypeID,
                CurrencyCode = dto.CurrencyCode,
                AccountNumber = dto.AccountNumber ?? GenerateAccountNumber(),
                Balance = dto.InitialBalance,
                OpenDate = DateTime.UtcNow,
                IsActive = true,
                CreatedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow
            };

            _context.Accounts.Add(account);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Account created", accountId = account.AccountID });
        }

        // ----------------------------
        // CLOSE account (soft-close)
        // ----------------------------
        [HttpPost("{id}/close")]
        public async Task<IActionResult> CloseAccount(int id)
        {
            var account = await _context.Accounts.FindAsync(id);
            if (account == null) return NotFound("Account not found.");

            // Only admin or owner can close (owner permitted)
            var loggedInUserId = int.Parse(User.FindFirst("UserID").Value);
            var isAdmin = User.IsInRole("Admin") || User.IsInRole("SYSAdmin");
            if (!isAdmin && account.UserID != loggedInUserId)
                return Forbid();

            // Business rule: Only close if balance is zero
            if (account.Balance != 0)
                return BadRequest("Account balance must be zero before closing.");

            account.IsActive = false;
            account.CloseDate = DateTime.UtcNow;
            account.ModifiedDate = DateTime.UtcNow;

            // Save closure transaction
            var tx = new Transaction
            {
                AccountID = account.AccountID,
                PerformedByUserID = loggedInUserId,
                TransactionType = "Closure",
                Amount = 0,
                CurrencyCode = account.CurrencyCode,
                TransactionDate = DateTime.UtcNow,
                Remarks = "Account closed"
            };
            _context.Transactions.Add(tx);

            await _context.SaveChangesAsync();
            return Ok("Account closed successfully.");
        }

        // ----------------------------
        // Deposit
        // ----------------------------
        [HttpPost("{id}/deposit")]
        public async Task<IActionResult> Deposit(int id, [FromBody] DepositDto dto)
        {
            if (dto.Amount <= 0) return BadRequest("Amount must be greater than zero.");

            var account = await _context.Accounts.FindAsync(id);
            if (account == null) return NotFound("Account not found.");
            if (!account.IsActive) return BadRequest("Account is not active.");

            var performerId = int.Parse(User.FindFirst("UserID").Value);

            using var dbtx = await _context.Database.BeginTransactionAsync();
            try
            {
                account.Balance += dto.Amount;
                account.ModifiedDate = DateTime.UtcNow;

                var tx = new Transaction
                {
                    AccountID = account.AccountID,
                    PerformedByUserID = performerId,
                    TransactionType = "Deposit",
                    Amount = dto.Amount,
                    CurrencyCode = account.CurrencyCode,
                    TransactionDate = DateTime.UtcNow,
                    Remarks = dto.Remarks
                };
                _context.Transactions.Add(tx);

                await _context.SaveChangesAsync();
                await dbtx.CommitAsync();

                return Ok(new { message = "Deposit successful", newBalance = account.Balance });
            }
            catch (Exception ex)
            {
                await dbtx.RollbackAsync();
                return StatusCode(500, "Deposit failed: " + ex.Message);
            }
        }

        // ----------------------------
        // Withdraw
        // ----------------------------
        [HttpPost("{id}/withdraw")]
        public async Task<IActionResult> Withdraw(int id, [FromBody] WithdrawDto dto)
        {
            if (dto.Amount <= 0) return BadRequest("Amount must be greater than zero.");

            var account = await _context.Accounts.FindAsync(id);
            if (account == null) return NotFound("Account not found.");
            if (!account.IsActive) return BadRequest("Account is not active.");

            var performerId = int.Parse(User.FindFirst("UserID").Value);

            using var dbtx = await _context.Database.BeginTransactionAsync();
            try
            {
                if (account.Balance < dto.Amount)
                    return BadRequest("Insufficient balance.");

                account.Balance -= dto.Amount;
                account.ModifiedDate = DateTime.UtcNow;

                var tx = new Transaction
                {
                    AccountID = account.AccountID,
                    PerformedByUserID = performerId,
                    TransactionType = "Withdrawal",
                    Amount = dto.Amount,
                    CurrencyCode = account.CurrencyCode,
                    TransactionDate = DateTime.UtcNow,
                    Remarks = dto.Remarks
                };
                _context.Transactions.Add(tx);

                await _context.SaveChangesAsync();
                await dbtx.CommitAsync();

                return Ok(new { message = "Withdrawal successful", newBalance = account.Balance });
            }
            catch (Exception ex)
            {
                await dbtx.RollbackAsync();
                return StatusCode(500, "Withdrawal failed: " + ex.Message);
            }
        }

        // ----------------------------
        // Transfer (from one account to another)
        // ----------------------------
        [HttpPost("transfer")]
        public async Task<IActionResult> Transfer([FromBody] TransferDto dto)
        {
            if (dto.Amount <= 0) return BadRequest("Amount must be greater than zero.");
            if (dto.FromAccountId == dto.ToAccountId) return BadRequest("From and To accounts must differ.");

            var fromAccount = await _context.Accounts.FindAsync(dto.FromAccountId);
            var toAccount = await _context.Accounts.FindAsync(dto.ToAccountId);

            if (fromAccount == null || toAccount == null) return NotFound("One or both accounts not found.");
            if (!fromAccount.IsActive || !toAccount.IsActive) return BadRequest("One or both accounts are inactive.");

            // currency check — require same currency for simple system
            if (!string.Equals(fromAccount.CurrencyCode, toAccount.CurrencyCode, StringComparison.OrdinalIgnoreCase))
                return BadRequest("Currency mismatch between accounts.");

            var performerId = int.Parse(User.FindFirst("UserID").Value);
            var isAdmin = User.IsInRole("Admin") || User.IsInRole("SYSAdmin");

            // If not admin, ensure performer owns the fromAccount
            if (!isAdmin && fromAccount.UserID != performerId)
                return Forbid();

            using var dbtx = await _context.Database.BeginTransactionAsync();
            try
            {
                if (fromAccount.Balance < dto.Amount)
                    return BadRequest("Insufficient funds in from-account.");

                fromAccount.Balance -= dto.Amount;
                fromAccount.ModifiedDate = DateTime.UtcNow;

                toAccount.Balance += dto.Amount;
                toAccount.ModifiedDate = DateTime.UtcNow;

                // Record both transactions
                var txOut = new Transaction
                {
                    AccountID = fromAccount.AccountID,
                    PerformedByUserID = performerId,
                    TransactionType = "Withdrawal",
                    Amount = dto.Amount,
                    CurrencyCode = fromAccount.CurrencyCode,
                    TransactionDate = DateTime.UtcNow,
                    Remarks = $"Transfer to {toAccount.AccountNumber}: {dto.Remarks}"
                };
                var txIn = new Transaction
                {
                    AccountID = toAccount.AccountID,
                    PerformedByUserID = performerId,
                    TransactionType = "Deposit",
                    Amount = dto.Amount,
                    CurrencyCode = toAccount.CurrencyCode,
                    TransactionDate = DateTime.UtcNow,
                    Remarks = $"Transfer from {fromAccount.AccountNumber}: {dto.Remarks}"
                };

                _context.Transactions.Add(txOut);
                _context.Transactions.Add(txIn);

                await _context.SaveChangesAsync();
                await dbtx.CommitAsync();

                return Ok(new
                {
                    message = "Transfer successful",
                    fromAccountBalance = fromAccount.Balance,
                    toAccountBalance = toAccount.Balance
                });
            }
            catch (Exception ex)
            {
                await dbtx.RollbackAsync();
                return StatusCode(500, "Transfer failed: " + ex.Message);
            }
        }

        private string GenerateAccountNumber()
        {
            // Simple generator — replace with your own logic as needed
            return $"AC{DateTime.UtcNow.Ticks % 1000000000:D9}";
        }
    }

    // DTOs used by the controller
    public class AccountListQueryDto
    {
        public int? UserId { get; set; }
        public string? Search { get; set; }
        public string? Sort { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }

    public class CreateAccountDto
    {
        public int UserID { get; set; }
        public int BranchID { get; set; }
        public int AccountTypeID { get; set; }
        public string CurrencyCode { get; set; } = "INR";
        public string? AccountNumber { get; set; }
        public decimal InitialBalance { get; set; } = 0m;
    }

    public class DepositDto
    {
        public decimal Amount { get; set; }
        public string? Remarks { get; set; }
    }

    public class WithdrawDto
    {
        public decimal Amount { get; set; }
        public string? Remarks { get; set; }
    }

    public class TransferDto
    {
        public int FromAccountId { get; set; }
        public int ToAccountId { get; set; }
        public decimal Amount { get; set; }
        public string? Remarks { get; set; }
    }
}
