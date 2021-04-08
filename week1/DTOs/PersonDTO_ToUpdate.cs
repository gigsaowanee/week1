using System;
using System.ComponentModel.DataAnnotations;

namespace week1.DTOs
{
    public class PersonDTO_ToUpdate
    {

        [MaxLength(10) ]
        public string Name { get; set; }

         [Range(40,200)]
        public double Weight { get; set; } = 40;

         [Range(140,220)]
         
        public double Height { get; set; } = 176;

        public string  BirthDate { get; set; }
    }
}