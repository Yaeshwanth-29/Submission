using System.Security.Claims;
using User_and_Account_Management.Models;

namespace User_and_Account_Management.Services
{
    public interface IJwtService
    {
        string GenerateRefreshToken();
        string GenerateJwtToken(User user, IList<string> roles);
        ClaimsPrincipal? ValidateToken(string token);
    }
}
