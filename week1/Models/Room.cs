using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace week1.Models
{
     [Table("Room", Schema = "Hotel")]
    public class Room
    {
        [Key]
        public int Id { get; set; }
         [Required]
        public string RoomId { get; set; }
         [Required]  
        public string Type { get; set; }
         [Required]
        public int People { get; set; }
         [Required]
        public int Floor { get; set; }
    }
}