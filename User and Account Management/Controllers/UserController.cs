using Microsoft.AspNetCore.Mvc;
using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using User_and_Account_Management.Controllers.DTOs;
using User_and_Account_Management.Models;

namespace User_and_Account_Management.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        // -------------------------------------------------------
        // CREATE USER
        // -------------------------------------------------------
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserDto dto)
        {
            var user = new User
            {
                Username = dto.Username,
                Email = dto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password)
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            // Assign Role
            var userRole = new UserRole
            {
                UserID = user.UserID,
                RoleID = dto.RoleId
            };

            _context.UserRoles.Add(userRole);
            await _context.SaveChangesAsync();

            return Ok(new { message = "User created successfully", userId = user.UserID });
        }

        // -------------------------------------------------------
        // GET ALL USERS
        // -------------------------------------------------------
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserResponseDto>>> GetUsers()
        {
            var users = await _context.Users
                .Include(x => x.UserRoles)
                .Select(u => new UserResponseDto
                {
                    UserID = u.UserID,
                    Username = u.Username,
                    Email = u.Email,
                    RoleId = u.UserRoles.First().RoleID
                })
                .ToListAsync();

            return Ok(users);
        }

        // -------------------------------------------------------
        // GET SINGLE USER
        // -------------------------------------------------------
        [HttpGet("{id}")]
        public async Task<ActionResult<UserResponseDto>> GetUser(int id)
        {
            var user = await _context.Users
                .Include(x => x.UserRoles)
                .FirstOrDefaultAsync(x => x.UserID == id);

            if (user == null)
                return NotFound("User not found");

            return new UserResponseDto
            {
                UserID = user.UserID,
                Username = user.Username,
                Email = user.Email,
                RoleId = user.UserRoles.First().RoleID
            };
        }

        // -------------------------------------------------------
        // UPDATE USER
        // -------------------------------------------------------
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, UpdateUserDto dto)
        {
            var user = await _context.Users
                .Include(u => u.UserRoles)
                .FirstOrDefaultAsync(u => u.UserID == id);

            if (user == null)
                return NotFound("User not found");

            user.Username = dto.Username;
            user.Email = dto.Email;

            if (!string.IsNullOrEmpty(dto.Password))
            {
                user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password);
            }

            // Update Role
            var userRole = user.UserRoles.FirstOrDefault();
            if (userRole != null)
            {
                userRole.RoleID = dto.RoleId;
            }

            await _context.SaveChangesAsync();

            return Ok("User updated successfully");
        }

        // -------------------------------------------------------
        // DELETE USER
        // -------------------------------------------------------
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users
                .Include(u => u.UserRoles)
                .FirstOrDefaultAsync(u => u.UserID == id);

            if (user == null)
                return NotFound("User not found");

            _context.UserRoles.RemoveRange(user.UserRoles);
            _context.Users.Remove(user);

            await _context.SaveChangesAsync();

            return Ok("User deleted successfully");
        }
    }
}
