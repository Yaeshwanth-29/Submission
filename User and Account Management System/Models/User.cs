using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User_and_Account_Management.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required, MaxLength(100)]
        public string FullName { get; set; }

        public DateTime? DOB { get; set; }

        [Required, MaxLength(100)]
        public string Username { get; set; }

        [Required, MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [MaxLength(20)]
        public string? PhoneNumber { get; set; }

        [MaxLength(200)]
        public string? Address { get; set; }

        public bool IsMinor { get; set; } = false;

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime ModifiedDate { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;

        // 🔗 Navigation Properties
        public ICollection<UserRole>? UserRoles { get; set; }
        public ICollection<Account>? Accounts { get; set; }
    }
}
