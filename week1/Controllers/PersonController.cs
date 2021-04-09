using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using week1.Data;
using week1.DTOs;
using week1.Models;

namespace week1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly AppDBContext _db;

        public PersonController( IMapper mapper,AppDBContext db){
            this._mapper = mapper; 
            this._db = db; 
        }

        [HttpGet("GetPerson")]
      public IActionResult GetPerson()
        {
             var person = _db.Persons.ToList();
             int count = person.Count();
             string text = "Total Persons = " + count.ToString() +"\n";
             foreach(var i in person){
             string personText = "Id: "+i.Id +"\n"+"Name: "+i.Name+"\n"+"Weight: "+i.Weight+"\n"+"Height: "+i.Height +"\n"+"BirthDate: "+i.BirthDate.ToString("dd/MM/yyyy") +"\n";
             text += "\n" + personText;
             }
           return Ok(text);
        }

        [HttpPost("InsertPerson")]
        public IActionResult InsertPerson(PersonDTO_ToCreate item){
              
             var person = new Person();

             person.Name = item.Name;
             person.Weight = item.Weight;
             person.Height = item.Height;
             person.BirthDate = item.BirthDate;

             _db.Persons.Add(person);
             _db.SaveChanges();

             var result = _mapper.Map<PersonDTO_ToReturn>(person);

            return Ok(result);
        }

        [HttpGet("GetPersonByWeight")]
         public IActionResult GetPersonByWeight(double searchMin , double searchMax)
        {
            
             var person = _db.Persons.ToList();
            var result = person.Where(x => x.Weight >= searchMin && x.Weight <= searchMax).ToList();
            return Ok(result);
        }

        [HttpPut("UpdatePerson/{id}")]
        public IActionResult UpdatePerson(PersonDTO_ToUpdate input , int id)
        {
             var person = _db.Persons.Where(x => x.Id == id).FirstOrDefault();

             
             person.Name = input.Name;
             person.Weight = input.Weight;
             person.Height = input.Height;
             person.BirthDate = Convert.ToDateTime(input.BirthDate);
            
             _db.SaveChanges();
             var result = _mapper.Map<PersonDTO_ToReturn>(person);

            return Ok(result);
        }

        [HttpDelete("DeletePersonById")]
        public IActionResult DeletePersonById(int id){
             var data =_db.Persons.ToList();
             var person = data.Where(x => x.Id.Equals(id)).FirstOrDefault();

             if(person == null)
             {
                 return NotFound("Not found Id: "+id);
             }else
             {
                _db.Persons.Remove(person);
             }

             _db.SaveChanges();

           var result = _mapper.Map<List<PersonDTO_ToReturn>>(data);

             return Ok(result);
        }

        }
    }
