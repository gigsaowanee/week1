using System.ComponentModel.DataAnnotations;

namespace week1.DTOs.Store
{
    public class ProductGroupDTO_ToUpdate
    {
         [Required(ErrorMessage = "GroupCode can't be null")]
        [StringLength(5, ErrorMessage = "GroupCode can be 1-5 digits")]
        public string GroupCode { get; set; }
        
        [Required(ErrorMessage = "Name can't be null")]
        public string Name { get; set; }
    }
}