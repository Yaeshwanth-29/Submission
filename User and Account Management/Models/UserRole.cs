using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User_and_Account_Management.Models
{
    [Table("UserRole")]
    public class UserRole
    {
        public int UserID { get; set; }
        public int RoleID { get; set; }

        // Navigation properties
        [ForeignKey(nameof(UserID))]
        public User? User { get; set; }

        [ForeignKey(nameof(RoleID))]
        public Role? Role { get; set; }
    }
}
