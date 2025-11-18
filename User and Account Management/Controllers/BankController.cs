using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using User_and_Account_Management.Models;

namespace User_and_Account_Management.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin,SYSAdmin")]
    public class BanksController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BanksController(AppDbContext context)
        {
            _context = context;
        }

        // GET /api/banks
        [HttpGet]
        public async Task<IActionResult> GetBanks([FromQuery] string? q)
        {
            var query = _context.Banks.AsQueryable();
            if (!string.IsNullOrWhiteSpace(q)) query = query.Where(b => b.BankName.Contains(q));
            var items = await query.OrderBy(b => b.BankName).ToListAsync();
            return Ok(items);
        }

        // POST /api/banks
        [HttpPost]
        public async Task<IActionResult> CreateBank([FromBody] CreateBankDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.BankName))
                return BadRequest("BankName required.");

            var exists = await _context.Banks.AnyAsync(b => b.BankName == dto.BankName);
            if (exists) return BadRequest("Bank already exists.");

            var bank = new Bank
            {
                BankName = dto.BankName,
                EstablishedDate = dto.EstablishedDate,
                Headquarters = dto.Headquarters,
                IsActive = dto.IsActive
            };

            _context.Banks.Add(bank);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Bank created", bankId = bank.BankID });
        }

        // DELETE /api/banks/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBank(int id)
        {
            var bank = await _context.Banks.Include(b => b.Branches).FirstOrDefaultAsync(b => b.BankID == id);
            if (bank == null) return NotFound("Bank not found.");

            if (bank.Branches.Any())
                return BadRequest("Cannot delete bank with existing branches. Delete branches first.");

            _context.Banks.Remove(bank);
            await _context.SaveChangesAsync();

            return Ok("Bank deleted.");
        }
    }

    public class CreateBankDto
    {
        public string BankName { get; set; } = string.Empty;
        public DateTime? EstablishedDate { get; set; }
        public string? Headquarters { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
