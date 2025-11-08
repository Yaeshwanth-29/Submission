using System.Collections.Generic;
using User_and_Account_Management.Models;
using User_and_Account_Management.Services;


public interface IJwtService
{
    string GenerateToken(User user, IList<string> roles);
}

