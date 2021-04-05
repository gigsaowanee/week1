using System;
using System.ComponentModel.DataAnnotations;

namespace week1.Models
{
    public class Book
    {        
        [Range(1,int.MaxValue)]
        public int Id { get; set; } 
        [Required]
        [MinLength(1),MaxLength(10)]
        public string Name { get; set; }
        [Range(0,5000)]
        public double Price { get; set; }
        public DateTime CreatedDate { get; set; }   
    }
}