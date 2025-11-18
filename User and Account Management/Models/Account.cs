using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User_and_Account_Management.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        public int AccountID { get; set; }

        // ------------------------
        // Foreign Keys
        // ------------------------
        [Required]
        public int UserID { get; set; }

        [Required]
        public int BankID { get; set; } // Added BankID

        [Required]
        public int BranchID { get; set; }

        [Required]
        public int AccountTypeID { get; set; }

        [Required]
        [StringLength(3)]
        public string CurrencyCode { get; set; } = string.Empty;

        // ------------------------
        // Account details
        // ------------------------
        [Required]
        [StringLength(20)]
        public string AccountNumber { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; } = 0.00m;

        public DateTime OpenDate { get; set; } = DateTime.UtcNow;
        public DateTime? CloseDate { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedDate { get; set; } = DateTime.UtcNow;

        // ------------------------
        // Navigation Properties
        // ------------------------
        [ForeignKey(nameof(UserID))]
        public virtual User User { get; set; } = null!;

        [ForeignKey(nameof(BankID))]
        public virtual Bank Bank { get; set; } = null!; // Added Bank navigation

        [ForeignKey(nameof(BranchID))]
        public virtual Branch Branch { get; set; } = null!;

        [ForeignKey(nameof(AccountTypeID))]
        public virtual AccountType AccountType { get; set; } = null!;

        [ForeignKey(nameof(CurrencyCode))]
        public virtual Currency Currency { get; set; } = null!;
    }
}
