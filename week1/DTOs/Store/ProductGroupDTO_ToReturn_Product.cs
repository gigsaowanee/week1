using System.Collections.Generic;
using week1.Models.Store;

namespace week1.DTOs.Store
{
    public class ProductGroupDTO_ToReturn_Product
    {
        public int Id { get; set; }
        public string GroupCode { get; set; }
        public string Name { get; set; }
        public List<ProductDTO_ToReturn> Product { get; set; }
    }
}