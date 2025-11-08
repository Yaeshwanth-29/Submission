using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User_and_Account_Management.Models
{
    [Table("Permission")]
    public class Permission
    {
        [Key]
        public int PermissionID { get; set; } // Primary Key

        [Required]
        [StringLength(100)]
        public string PermissionName { get; set; } = string.Empty;

        [StringLength(200)]
        public string? Description { get; set; }

        // Navigation property
        public ICollection<RolePermission>? RolePermissions { get; set; }
    }
}
