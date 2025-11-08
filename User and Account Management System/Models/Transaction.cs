using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User_and_Account_Management.Models
{
    [Table("Transaction")]
    public class Transaction
    {
        [Key]
        public long TransactionID { get; set; }

        [Required]
        public int AccountID { get; set; }

        [Required]
        public int PerformedByUserID { get; set; }

        [Required, MaxLength(20)]
        [RegularExpression("Deposit|Withdrawal|BalanceCheck|Closure")]
        public string TransactionType { get; set; } // Deposit, Withdrawal, etc.

        [Range(0, double.MaxValue)]
        public decimal Amount { get; set; }

        [Required, StringLength(3)]
        public string CurrencyCode { get; set; }

        public DateTime TransactionDate { get; set; } = DateTime.Now;

        [MaxLength(250)]
        public string? Remarks { get; set; }

        // 🔗 Navigation Properties
        [ForeignKey(nameof(AccountID))]
        public Account Account { get; set; }

        [ForeignKey(nameof(PerformedByUserID))]
        public User PerformedByUser { get; set; }

        [ForeignKey(nameof(CurrencyCode))]
        public Currency Currency { get; set; }
    }
}
