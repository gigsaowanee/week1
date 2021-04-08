using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace week1.Models
{
      [Table("Employee", Schema = "sale")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
         [Required]
        public string Name { get; set; }    
         [Required]
        public int Age { get; set; }
         [Required]
        public string Position { get; set; }
         [Required]      
         public string Department { get; set; }
    }
}