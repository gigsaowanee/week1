using System;
using System.ComponentModel.DataAnnotations;

namespace week1.DTOs
{
    public class PersonDTO_ToCreate
    {
       
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