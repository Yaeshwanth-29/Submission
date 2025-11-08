using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User_and_Account_Management.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        public int AccountID { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public int UserID { get; set; }

        [Required]
        [ForeignKey(nameof(Branch))]
        public int BranchID { get; set; }

        [Required]
        [ForeignKey(nameof(AccountType))]
        public int AccountTypeID { get; set; }

        [Required]
        [ForeignKey(nameof(Currency))]
        [StringLength(3)]
        public string CurrencyCode { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string AccountNumber { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; } = 0.00m;

        public DateTime OpenDate { get; set; } = DateTime.Now;
        public DateTime? CloseDate { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime ModifiedDate { get; set; } = DateTime.Now; // ✅ Added

       
        public virtual User User { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual AccountType AccountType { get; set; }
        public virtual Currency Currency { get; set; }

        
    }
}
