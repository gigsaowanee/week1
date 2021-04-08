using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using week1.Models;
using week1.DTOs;
using week1.Data;

namespace week1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly AppDBContext _db;

        public EmployeesController( IMapper mapper ,AppDBContext db)
        {
            this._mapper = mapper;
            this._db = db;
        }

          [HttpGet("GetEmployeeByDepartment/{dept}")]
          public IActionResult GetEmployeeByDepartment(string dept){

              var dataEmp = _db.Employees.Where(x => x.Department.ToUpper().Contains(dept.ToUpper())).ToList();
              var result = _mapper.Map<List<EmployeeDTO_ToReturn>>(dataEmp);
              return Ok(result);

          }
        
    }
}