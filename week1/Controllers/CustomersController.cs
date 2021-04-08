using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using week1.Models;
using week1.DTOs;
using System.Linq;
using AutoMapper;
using week1.Data;

namespace week1.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class CustomersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly AppDBContext _db;
  
        public CustomersController(IMapper mapper,AppDBContext db)
        {
            this._mapper = mapper;
            this._db = db;
        }


        [HttpGet("{id}")] //url/api/controler/id

        public IActionResult GetCustomer(int id){
            var customer = _db.Customers.Where(x => x.Id == id).FirstOrDefault();            
            var result = _mapper.Map<CustomerDTO_ToReturn>(customer); 
            return Ok(result);
        }
        
        [HttpGet]
        public IActionResult GetAllCustomer(){
           var customer = _db.Customers.ToList();
                                  
            var result = _mapper.Map<List<CustomerDTO_ToReturn>>(customer); 
            return Ok(result);
        }

        [HttpPost("CreateCustomer")]
        public IActionResult CreateCustomer(CustomerDTO_ToCreate input){
         
         var customer = new Customer();

         customer.Firstname = input.Firstname;
         customer.ATMCode = input.ATMCode;
         customer.Balance = input.Balance;
         customer.BankAccount = input.BankAccount;

          _db.Customers.Add(customer); //เพิ่มลง DB
          _db.SaveChanges(); //รันคำสั่ง

          var resultToReturn = _mapper.Map<CustomerDTO_ToReturn>(customer);

          return Ok(resultToReturn);
        }
       
        
    }
}