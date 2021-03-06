using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace week1.Models
{
    [Table("Customer", Schema = "sale")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(15)]
         public string BankAccount { get; set; }
        [Required]
        [StringLength(6)]
        public string ATMCode { get; set; }
        [Required]
        public double Balance { get; set; }
    }
}