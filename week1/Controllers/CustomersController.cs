using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using week1.Models;
using week1.DTOs;
using System.Linq;
using AutoMapper;

namespace week1.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class CustomersController : ControllerBase
    {
        private readonly IMapper _mapper;    
        private List<Customer> customerList = new List<Customer>();

  
        public CustomersController(IMapper mapper)
        {
            customerList.Add(new Customer() { Id = 1, Firstname = "A", BankAccount = "111", Balance = 100, ATMCode ="12345"});
            customerList.Add(new Customer() { Id = 2, Firstname = "B", BankAccount = "222", Balance = 200, ATMCode ="12345"});
            customerList.Add(new Customer() { Id = 3, Firstname = "C", BankAccount = "333", Balance = 300 ,ATMCode ="12345"});
            customerList.Add(new Customer() { Id = 4, Firstname = "D", BankAccount = "444", Balance = 400, ATMCode ="12345"});
            customerList.Add(new Customer() { Id = 5, Firstname = "E", BankAccount = "555", Balance = 500 ,ATMCode ="12345"});
            this._mapper = mapper;
        }

        // [HttpGet]
        // public IActionResult GetAllCustomer(){
        //  return Ok(customerList);
        // }

         //No aujto Mapper
        // [HttpGet("{id}")]  // url/api/Customer/1
        // public IActionResult GetCustomer(int id) {
        //     var result = customerList.Where(x => x.Id == id).SingleOrDefault();

        //     var resultToReturn = new CustomerDTO_ToReturn();
        //     //No AutoMapper
        //     resultToReturn.Id = result.Id;
        //     resultToReturn.FirstName = result.FirstName;
        //     resultToReturn.BankAccount = result.BankAccount;
        //     resultToReturn.Balance = result.Balance;

        //     return Ok(resultToReturn);
        // }


        [HttpGet("{id}")] //url/api/controler/id

        public IActionResult GetCustomer(int id){
            var customerFromGet = customerList.Where(x => x.Id == id).SingleOrDefault();
                                     //from                //to
            var result = _mapper.Map<CustomerDTO_ToReturn>(customerFromGet); 
            return Ok(result);
        }
        
        [HttpGet]
        public IActionResult GetAllCustomer(){
            var result =_mapper.Map<List<CustomerDTO_ToReturn>>(customerList);
         return Ok(result);
        }
       
        
    }
}