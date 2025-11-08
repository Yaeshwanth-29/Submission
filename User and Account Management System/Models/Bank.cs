using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User_and_Account_Management.Models
{
    [Table("Bank")]
    public class Bank
    {
        [Key]
        public int BankID { get; set; }

        [Required]
        [StringLength(100)]
        public string BankName { get; set; } = string.Empty;

        public DateTime? EstablishedDate { get; set; }

        [StringLength(200)]
        public string? Headquarters { get; set; }

        public bool IsActive { get; set; } = true;

       
        public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();
    }
}
