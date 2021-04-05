using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using week1.Models;

namespace week1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private List<Person> PersonData()
        {
            var person = new List<Person>();
            person.Add(new Person() { Id = 1, Name = "Poo", Weight = 50, Height = 165, BirthDate = new DateTime(1998, 01, 11) });
            person.Add(new Person() { Id = 2, Name = "Pla", Weight = 45, Height = 166, BirthDate = new DateTime(1999, 02, 02) });
            person.Add(new Person() { Id = 3, Name = "Ta", Weight = 47, Height = 159, BirthDate = new DateTime(1997, 03, 14) });
            person.Add(new Person() { Id = 4, Name = "Ploy", Weight = 60, Height = 170, BirthDate = new DateTime(1996, 04, 23) });
            person.Add(new Person() { Id = 5, Name = "Gig", Weight = 45, Height = 177, BirthDate = new DateTime(1995, 05, 22) });
            person.Add(new Person() { Id = 6, Name = "Man", Weight = 78, Height = 180, BirthDate = new DateTime(1994, 06, 21) });
            person.Add(new Person() { Id = 7, Name = "Jib", Weight = 90, Height = 178, BirthDate = new DateTime(1993, 07, 10) });
            person.Add(new Person() { Id = 8, Name = "Joy", Weight = 12, Height = 165, BirthDate = new DateTime(1992, 08, 18) });
            person.Add(new Person() { Id = 9, Name = "Joom", Weight = 58, Height = 166, BirthDate = new DateTime(1997, 09, 28) });
            person.Add(new Person() { Id = 10, Name = "Faii", Weight = 60, Height = 170, BirthDate = new DateTime(1998, 11, 30) });

            return person;
        }

        [HttpGet("GetPerson")]
      public IActionResult GetPerson()
        {
             var person = PersonData();
             int count = person.Count();
             string text = "Total Persons = " + count.ToString() +"\n";
             foreach(var i in person){
             string personText = "Id: "+i.Id +"\n"+"Name: "+i.Name+"\n"+"Weight: "+i.Weight+"\n"+"Height: "+i.Height +"\n"+"BirthDate: "+i.BirthDate.ToString("dd/MM/yyyy") +"\n";
             text += "\n" + personText;
             }
           return Ok(text);
        }

        [HttpPost("InsertPerson")]
        public IActionResult InsertPerson(Person item){
              var person = PersonData();

            person.Add(new Person() { Id = item.Id , Name = item.Name, Weight = item.Weight, Height = item.Height, BirthDate = item.BirthDate });
            var result = person.Where(x => x.Id.Equals(item.Id)).FirstOrDefault();
            string text = "Insert Successfully" + "\n\n" + "Id: "+result.Id +"\n"+"Name: "+result.Name+"\n"+"Weight: "+result.Weight+"\n"+"Height: "+result.Height +"\n"+"BirthDate: "+result.BirthDate.ToString("dd/MM/yyyy");
            return Ok(text);
        }

        [HttpGet("GetPersonByWeight")]
         public IActionResult GetPersonByWeight(double searchMin , double searchMax)
        {
            var person = PersonData();
            var result = person.Where(x => x.Weight >= searchMin && x.Weight <= searchMax).ToList();
            return Ok(result);
        }

        [HttpPut("UpdateWeightAndHeight")]
        public IActionResult UpdateWeightAndHeight(int id , double weight, double height)
        {
            var person = PersonData().Where(x => x.Id.Equals(id)).FirstOrDefault();
            
            if(weight != 0 )
            {
            person.Weight = weight;
            }

            if(height != 0 )
            {
               person.Height = height;
            }
            string text = "Update Successfully" + "\n\n" + "Id: " + person.Id + "\n" + "Name: " + person.Name + "\n" + "Weight: " + person.Weight + "\n" + "Height: " + person.Height + "\n" + "BirthDate: " + person.BirthDate.ToString("dd/MM/yyyy");
            return Ok(text);
        }

        [HttpDelete("DeletePersonById")]
        public IActionResult DeletePersonById(int id){
             var person = PersonData();
             person.RemoveAll(x => x.Id.Equals(id));
             return Ok(person);
        }

    }
}