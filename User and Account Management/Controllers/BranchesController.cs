using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using User_and_Account_Management.Models;

namespace User_and_Account_Management.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin,SYSAdmin")]
    public class BranchesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BranchesController(AppDbContext context)
        {
            _context = context;
        }

        // GET /api/branches?bankId=1
        [HttpGet]
        public async Task<IActionResult> GetBranches([FromQuery] int? bankId, [FromQuery] string? q)
        {
            var query = _context.Branches.Include(b => b.Bank).AsQueryable();
            if (bankId.HasValue) query = query.Where(b => b.BankID == bankId.Value);
            if (!string.IsNullOrWhiteSpace(q)) query = query.Where(b => b.BranchName.Contains(q) || b.City.Contains(q));
            var items = await query.OrderBy(b => b.BranchName).ToListAsync();
            return Ok(items);
        }

        // POST /api/branches
        [HttpPost]
        public async Task<IActionResult> CreateBranch([FromBody] CreateBranchDto dto)
        {
            if (!await _context.Banks.AnyAsync(b => b.BankID == dto.BankID))
                return BadRequest("Invalid BankID.");

            var branch = new Branch
            {
                BankID = dto.BankID,
                BranchName = dto.BranchName,
                Address = dto.Address,
                City = dto.City,
                IFSCCode = dto.IFSCCode,
                ContactNumber = dto.ContactNumber,
                IsActive = dto.IsActive
            };

            _context.Branches.Add(branch);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Branch created", branchId = branch.BranchID });
        }

        // DELETE /api/branches/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBranch(int id)
        {
            var branch = await _context.Branches.Include(b => b.Accounts).FirstOrDefaultAsync(b => b.BranchID == id);
            if (branch == null) return NotFound("Branch not found.");

            if (branch.Accounts.Any())
                return BadRequest("Cannot delete branch with existing accounts. Close or move accounts first.");

            _context.Branches.Remove(branch);
            await _context.SaveChangesAsync();

            return Ok("Branch deleted.");
        }
    }

    public class CreateBranchDto
    {
        public int BankID { get; set; }
        public string BranchName { get; set; } = string.Empty;
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? IFSCCode { get; set; }
        public string? ContactNumber { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
