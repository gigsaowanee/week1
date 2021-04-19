using System.Collections.Generic;
using System.Threading.Tasks;
using week1.DTOs.Store;
using week1.Models;

namespace week1.Services.Orders
{
    public interface IOrderService
    {
         Task<ServiceResponse<OrderDTO_ToReturn>> GetOrderById(int id);

         Task<ServiceResponse<OrderDTO_ToReturn>> InsertOrder(OrderOrderDetailDTO_ToCreate input);
    }
}