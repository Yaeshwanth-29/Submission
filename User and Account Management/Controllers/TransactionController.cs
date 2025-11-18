using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using User_and_Account_Management.Controllers.DTOs;
using User_and_Account_Management.Models;

namespace User_and_Account_Management.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TransactionController(AppDbContext context)
        {
            _context = context;
        }

        // =============================================================
        // DEPOSIT
        // =============================================================
        [HttpPost("deposit")]
        public async Task<IActionResult> Deposit(TransactionRequestDto dto)
        {
            if (dto.Amount <= 0)
                return BadRequest("Amount must be greater than zero.");

            var account = await _context.Accounts
                .FirstOrDefaultAsync(a => a.UserID == dto.UserID);

            if (account == null)
                return NotFound("Account not found.");

            // Transactional update
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                account.Balance += dto.Amount;
                _context.Accounts.Update(account);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                return Ok(new TransactionResponseDto
                {
                    Message = $"Deposited {dto.Amount:C} successfully.",
                    CurrentBalance = account.Balance
                });
            }
            catch
            {
                await transaction.RollbackAsync();
                return StatusCode(500, "Deposit failed.");
            }
        }

        // =============================================================
        // WITHDRAW
        // =============================================================
        [HttpPost("withdraw")]
        public async Task<IActionResult> Withdraw(TransactionRequestDto dto)
        {
            if (dto.Amount <= 0)
                return BadRequest("Amount must be greater than zero.");

            var account = await _context.Accounts
                .FirstOrDefaultAsync(a => a.UserID == dto.UserID);

            if (account == null)
                return NotFound("Account not found.");

            if (account.Balance < dto.Amount)
                return BadRequest("Insufficient balance.");

            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                account.Balance -= dto.Amount;
                _context.Accounts.Update(account);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                return Ok(new TransactionResponseDto
                {
                    Message = $"Withdrew {dto.Amount:C} successfully.",
                    CurrentBalance = account.Balance
                });
            }
            catch
            {
                await transaction.RollbackAsync();
                return StatusCode(500, "Withdrawal failed.");
            }
        }

        // =============================================================
        // GET ACCOUNT BALANCE
        // =============================================================
        [HttpGet("balance/{userId}")]
        public async Task<IActionResult> GetBalance(int userId)
        {
            var account = await _context.Accounts
                .FirstOrDefaultAsync(a => a.UserID == userId);

            if (account == null)
                return NotFound("Account not found.");

            return Ok(new { account.Balance });
        }
    }
}
