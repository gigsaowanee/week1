using System.Collections.Generic;

namespace week1.DTOs.Store
{
    public class OrderOrderDetailDTO_ToCreate
    {
        public OrderDTO_ToCreate Order { get; set; }
        public List<OrderDetailDTO_ToCreate> OrderDetail { get; set; }
    }
}