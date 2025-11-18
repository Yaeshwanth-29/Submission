using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User_and_Account_Management.Models
{
    [Table("Branch")]
    public class Branch
    {
        [Key]
        public int BranchID { get; set; }

        [ForeignKey(nameof(Bank))]
        public int BankID { get; set; }

        [Required]
        [StringLength(100)]
        public string BranchName { get; set; } = string.Empty;

        [StringLength(200)]
        public string? Address { get; set; }

        [StringLength(100)]
        public string? City { get; set; }

        [StringLength(20)]
        public string? IFSCCode { get; set; }

        [StringLength(15)]
        public string? ContactNumber { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public virtual Bank Bank { get; set; } = null!;

        // One Branch → Many Employees
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

        // One Branch → Many Accounts
        public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
    }
}
