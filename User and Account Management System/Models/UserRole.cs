using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User_and_Account_Management.Models
{
    [Table("UserRole")]
    public class UserRole
    {
        [Key, Column(Order = 0)]
        public int UserID { get; set; }

        [Key, Column(Order = 1)]
        public int RoleID { get; set; }

        // 🔗 Navigation properties
        [ForeignKey(nameof(UserID))]
        public required User User { get; set; }

        [ForeignKey(nameof(RoleID))]
        public required Role Role { get; set; }
    }
}
