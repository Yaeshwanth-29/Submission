using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User_and_Account_Management.Models
{
    [Table("AccountType")]
    public class AccountType
    {
        [Key]
        public int AccountTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string TypeName { get; set; } = string.Empty;

        [StringLength(200)]
        public string? Description { get; set; }

        
        public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
    }
}
