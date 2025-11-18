namespace User_and_Account_Management.Controllers.DTOs
{
    public class CreateUserDto
    {
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public int RoleId { get; set; }
    }

    public class UpdateUserDto
    {
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public int RoleId { get; set; }
    }

    public class ChangePasswordDto
    {
        public string NewPassword { get; set; } = string.Empty;
    }

    public class UserResponseDto
    {
        public int UserID { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public int RoleId { get; set; }
    }
}
