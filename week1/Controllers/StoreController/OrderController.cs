using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using week1.Data;
using week1.DTOs.Store;
using week1.Models.Store;

namespace week1.Controllers.StoreController
{

     [ApiController] 
    [Route("api/[controller]")]
    public class OrderController: ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly AppDBContext _db;

        public OrderController (IMapper mapper, AppDBContext db){
            this._mapper = mapper;
            this._db = db;
        }

        [HttpPost("InsertOrder")]
        public IActionResult InsertOrder(OrderOrderDetailDTO_ToCreate input){
            var order = new Order();

            order.TotalPrice = input.Order.TotalPrice;
            order.TotalCount = input.Order.TotalCount;
            order.PaymentType = input.Order.PaymentType;
            order.OrderStatus = input.Order.OrderStatus;
            order.OrderDate = DateTime.Now;

            _db.Orders.Add(order);
            _db.SaveChanges();

            foreach(var i in input.OrderDetail){

            var checkOrderDetail = _db.OrderDetails.Where( x => x.ProductId == i.ProductId && x.OrderId == order.Id).FirstOrDefault();

            if (checkOrderDetail == null)
            {
                 var orderDetail = new OrderDetail();
              orderDetail.OrderId = order.Id;
              orderDetail.ProductId = i.ProductId;
              orderDetail.QTY = i.QTY;
              orderDetail.OrderDetailDate = DateTime.Now;

              _db.OrderDetails.Add(orderDetail);
              _db.SaveChanges();
            }else{

                checkOrderDetail.QTY = checkOrderDetail.QTY + i.QTY;
                _db.SaveChanges();
            }
        }

        var returnOrder = _db.Orders.Include(x => x.OrderDetail).Where(x => x.Id == order.Id).FirstOrDefault();
        var result = _mapper.Map<OrderDTO_ToReturn>(returnOrder);
            return Ok(result);   

        }
        [HttpPost("GetorderById")]
        public IActionResult GetOrder(int id){
            var order = _db.Orders.Include(x => x.OrderDetail).ThenInclude(x => x.Product).ThenInclude(x => x.ProductGroup).Where(x => x.Id == id).FirstOrDefault();

            if(order == null){
                return NotFound("Not found Id "+ id);
            }
            else
            {
            var result = _mapper.Map<OrderDTO_ToReturn>(order);

            return Ok(result);
            }
        }

    }
}