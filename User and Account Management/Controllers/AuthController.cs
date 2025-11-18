using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using User_and_Account_Management.Controllers.DTOs;
using User_and_Account_Management.Models;
using User_and_Account_Management.Services;

namespace User_and_Account_Management.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IJwtService _jwt;

        public AuthController(AppDbContext context, IJwtService jwt)
        {
            _context = context;
            _jwt = jwt;
        }

        // ===================================================================
        // REGISTER
        // ===================================================================
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Username) ||
                string.IsNullOrWhiteSpace(dto.Password) ||
                string.IsNullOrWhiteSpace(dto.Email))
            {
                return BadRequest("Username, password, and email are required.");
            }

            if (await _context.Users.AnyAsync(u => u.Username == dto.Username))
                return BadRequest("Username already exists.");

            if (await _context.Users.AnyAsync(u => u.Email == dto.Email))
                return BadRequest("Email already registered.");

            var hash = ComputeSha256Base64(dto.Password);

            var user = new User
            {
                FullName = dto.FullName,
                DOB = dto.DOB,
                Email = dto.Email,
                Username = dto.Username,
                PasswordHash = hash,
                CreatedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow,
                IsActive = true
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            // Ensure default role exists
            var role = await _context.Roles.FirstOrDefaultAsync(r => r.RoleName == "User");
            if (role == null)
            {
                role = new Role { RoleName = "User" };
                _context.Roles.Add(role);
                await _context.SaveChangesAsync();
            }

            _context.UserRoles.Add(new UserRole
            {
                UserID = user.UserID,
                RoleID = role.RoleID
            });

            await _context.SaveChangesAsync();

            return Ok(new { message = "User registered successfully." });
        }

        // ===================================================================
        // LOGIN
        // ===================================================================
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Username) || string.IsNullOrWhiteSpace(dto.Password))
                return BadRequest("Username and password required.");

            var user = await _context.Users
                .Include(u => u.UserRoles)
                    .ThenInclude(ur => ur.Role)
                .FirstOrDefaultAsync(u => u.Username == dto.Username);

            if (user == null || !VerifySha256Base64(dto.Password, user.PasswordHash))
                return Unauthorized("Invalid username or password.");

            // Extract roles
            var roles = user.UserRoles?
                .Where(ur => ur.Role != null)
                .Select(ur => ur.Role!.RoleName)
                .ToList() ?? new List<string>();

            // Generate access token
            var accessToken = _jwt.GenerateJwtToken(user, roles);

            // Generate refresh token
            var refreshToken = _jwt.GenerateRefreshToken();

            // Save refresh token in DB
            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiry = DateTime.UtcNow.AddDays(7); // 7 days expiry
            await _context.SaveChangesAsync();

            return Ok(new AuthResponseDto
            {
                Token = accessToken,
                RefreshToken = refreshToken,
                Username = user.Username,
                FullName = user.FullName,
                Roles = roles
            });
        }

        // ===================================================================
        // REFRESH TOKEN
        // ===================================================================
        [HttpPost("refresh")]
        public async Task<IActionResult> Refresh(TokenRefreshDto dto)
        {
            var user = await _context.Users
                .Include(u => u.UserRoles)
                    .ThenInclude(ur => ur.Role)
                .FirstOrDefaultAsync(u => u.RefreshToken == dto.RefreshToken);

            if (user == null || user.RefreshTokenExpiry < DateTime.UtcNow)
                return Unauthorized("Invalid or expired refresh token.");

            var roles = user.UserRoles?
                .Where(ur => ur.Role != null)
                .Select(ur => ur.Role!.RoleName)
                .ToList() ?? new List<string>();

            var newAccessToken = _jwt.GenerateJwtToken(user, roles);
            var newRefreshToken = _jwt.GenerateRefreshToken();

            user.RefreshToken = newRefreshToken;
            user.RefreshTokenExpiry = DateTime.UtcNow.AddDays(7);
            await _context.SaveChangesAsync();

            return Ok(new AuthResponseDto
            {
                Token = newAccessToken,
                RefreshToken = newRefreshToken,
                Username = user.Username,
                FullName = user.FullName,
                Roles = roles
            });
        }

        // ===================================================================
        // SHA256 Helpers
        // ===================================================================
        private static string ComputeSha256Base64(string input)
        {
            using var sha = System.Security.Cryptography.SHA256.Create();
            return Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(input)));
        }

        private static bool VerifySha256Base64(string input, string storedBase64Hash)
        {
            if (string.IsNullOrWhiteSpace(storedBase64Hash)) return false;
            return ComputeSha256Base64(input) == storedBase64Hash;
        }
    }
}
