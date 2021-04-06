using System;
using System.ComponentModel.DataAnnotations;

namespace week1.Models
{
    public class Person
    {
        [Required]
        [Range(1,int.MaxValue)]
        public int Id { get; set; } 
        
        [Required]
        [MaxLength(10) ]
        public string Name { get; set; }
        
         [Range(40,200)]
        public double Weight { get; set; }

         [Range(140,220)]
        public double Height { get; set; }

        [Required]
        public DateTime  BirthDate { get; set; }

    }
}