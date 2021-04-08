using System.ComponentModel.DataAnnotations;

namespace week1.DTOs
{
    public class CustomerDTO_ToCreate
    {

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