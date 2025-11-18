using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User_and_Account_Management.Models
{
    [Table("Currency")]
    public class Currency
    {
        [Key]
        [StringLength(10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // ✅ prevents EF from expecting auto-increment
        public string CurrencyCode { get; set; } = string.Empty; // Primary Key

        [Required]
        [StringLength(50)]
        public string CurrencyName { get; set; } = string.Empty;

        [StringLength(10)]
        public string Symbol { get; set; } = string.Empty;
    }
}
