using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User_and_Account_Management.Models
{
    [Table("RolePermission")]
    public class RolePermission
    {
        [Key, Column(Order = 0)]
        public int RoleID { get; set; }

        [Key, Column(Order = 1)]
        public int PermissionID { get; set; }

        // Navigation properties
        [ForeignKey(nameof(RoleID))]
        public required Role Role { get; set; }

        [ForeignKey(nameof(PermissionID))]
        public required Permission Permission { get; set; }
    }
}
