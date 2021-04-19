using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using week1.Data;
using week1.DTOs.Store;
using week1.Models.Store;
using week1.Services.Orders;

namespace week1.Controllers.StoreController
{

     [ApiController] 
    [Route("api/[controller]")]
    public class OrdersController: ControllerBase
    {
        private readonly IOrderService _order;

        public OrdersController(IOrderService order){
            this._order = order;
        }
        [HttpPost("InsertOrder")]
        public async Task<IActionResult> InsertOrderAsync(OrderOrderDetailDTO_ToCreate input){
            var result = await _order.InsertOrder(input);
            return Ok(result);   

        }

        [HttpGet("GetorderById/{id}")]
        public async Task<IActionResult> GetOrderById(int id){
           
           var result = await _order.GetOrderById(id);

            return Ok(result);
            }


        }

    }
