using System.ComponentModel.DataAnnotations;

namespace week1.DTOs.Store
{
    public class ProductDTO_ToUpdate
    {
       public int ProductGroupId { get; set; }
        
        [Required (ErrorMessage = "Name can't be null")]
        public string Name { get; set; }
       
        [Range(1,int.MaxValue,ErrorMessage = "Number of Product can't be 0")]
        public int NumberOfProduct { get; set; }
        
        [Range(1,int.MaxValue,ErrorMessage = "Price can't be 0")]
        public int Price { get; set; }
    }
}