using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using User_and_Account_Management.Models;

namespace User_and_Account_Management.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class AccountController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        // ✅ GET all accounts - Admin, SYSAdmin, ManagerUser
        [HttpGet]
        [Authorize(Roles = "Admin,SYSAdmin,ManagerUser")]
        public async Task<IActionResult> GetAllAccounts()
        {
            var accounts = await _context.Accounts
                .Include(a => a.User)
                .Include(a => a.Currency)
                .ToListAsync();

            return Ok(accounts.Select(a => new
            {
                a.AccountID,
                a.AccountNumber,
                a.Balance,
                a.CurrencyCode,
                a.UserID,
                a.User.Username
            }));
        }

        // ✅ GET single account - self or Admin/SYSAdmin
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccountById(int id)
        {
            var account = await _context.Accounts
                .Include(a => a.User)
                .FirstOrDefaultAsync(a => a.AccountID == id);

            if (account == null)
                return NotFound("Account not found.");

            var loggedInUserId = int.Parse(User.FindFirst("UserID").Value);
            var isAdmin = User.IsInRole("Admin") || User.IsInRole("SYSAdmin");

            if (account.UserID != loggedInUserId && !isAdmin)
                return Forbid();

            return Ok(account);
        }

        // ✅ POST create account - Admin or SYSAdmin only
        [HttpPost]
        [Authorize(Roles = "Admin,SYSAdmin")]
        public async Task<IActionResult> CreateAccount([FromBody] CreateAccountRequest request)
        {
            if (!await _context.Users.AnyAsync(u => u.UserID == request.UserID))
                return BadRequest("Invalid UserID.");

            var account = new Account
            {
                UserID = request.UserID,
                AccountNumber = request.AccountNumber,
                Balance = request.InitialBalance,
                CurrencyCode = request.CurrencyCode,
                CreatedDate = DateTime.Now
            };

            _context.Accounts.Add(account);
            await _context.SaveChangesAsync();
            return Ok("Account created successfully.");
        }

        // ✅ PUT update account - Admin, SYSAdmin, ManagerUser
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin,SYSAdmin,ManagerUser")]
        public async Task<IActionResult> UpdateAccount(int id, [FromBody] UpdateAccountRequest request)
        {
            var account = await _context.Accounts.FindAsync(id);
            if (account == null)
                return NotFound("Account not found.");

            account.Balance = request.Balance;
            account.CurrencyCode = request.CurrencyCode;
            account.ModifiedDate = DateTime.Now;

            await _context.SaveChangesAsync();
            return Ok("Account updated successfully.");
        }

        // ✅ DELETE account - SYSAdmin only
        [HttpDelete("{id}")]
        [Authorize(Roles = "SYSAdmin")]
        public async Task<IActionResult> DeleteAccount(int id)
        {
            var account = await _context.Accounts.FindAsync(id);
            if (account == null)
                return NotFound("Account not found.");

            _context.Accounts.Remove(account);
            await _context.SaveChangesAsync();
            return Ok("Account deleted successfully.");
        }
    }

    public class CreateAccountRequest
    {
        public int UserID { get; set; }
        public string AccountNumber { get; set; } = string.Empty;
        public decimal InitialBalance { get; set; }
        public string CurrencyCode { get; set; } = string.Empty;
    }

    public class UpdateAccountRequest
    {
        public decimal Balance { get; set; }
        public string CurrencyCode { get; set; } = string.Empty;
    }
}
