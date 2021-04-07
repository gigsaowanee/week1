using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using week1.Models;
using week1.DTOs;

namespace week1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private List<Employee> employeeList = new List<Employee>(); 

          public EmployeesController( IMapper mapper)
          {
              employeeList.Add(new Employee() { Id = 1 , Name = "Miw" , Age = 24 ,Position = "Manager" ,Department="IT"});
              employeeList.Add(new Employee() { Id = 2 , Name = "Maw" , Age = 22 ,Position = "Programmer" ,Department="Production "});
              employeeList.Add(new Employee() { Id = 3 , Name = "Meaw" ,Age = 21 ,Position = "Engineer" ,Department="HR"});
              employeeList.Add(new Employee() { Id = 4 , Name = "Moo" , Age = 36 ,Position = "Sale" ,Department="Production"});
              employeeList.Add(new Employee() { Id = 5 , Name = "Man" , Age = 28 ,Position = "Designer" ,Department="HR"});
              this._mapper = mapper;
        }

          [HttpGet("GetEmployeeByDepartment/{dept}")]
          public IActionResult GetEmployeeByDepartment(string dept){

              var dataEmp = employeeList.Where(x => x.Department.ToUpper().Contains(dept.ToUpper())).ToList();
              var result = _mapper.Map<List<EmployeeDTO_ToReturn>>(dataEmp);
              return Ok(result);

          }
        
    }
}