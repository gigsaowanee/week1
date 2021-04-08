using System;
using week1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using week1.Data;

namespace week1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly AppDBContext _db;

        public BooksController(IMapper mapper,AppDBContext db)
        {
            this._mapper = mapper;
            this._db = db;
        }

        [HttpGet]
        public IActionResult Get(string name)
        {
            var result = "Hello" + name;
            return Ok(result);
        }
        [HttpGet("News")]
        public IActionResult GetNews(string name)
        {
            var result = "Hello" + name;
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Create(int id, string name){
            var result = id.ToString() + " "+ name;
            return Ok(result);
        }

         [HttpPost]
         [Route("FindGPA")]
        public IActionResult FindGPA(float math, float eng, float scient){
            float result = (math + eng + scient)/3;
            return Ok(result.ToString("F"));
        }

         [HttpPost]
         [Route("FindGrade")]
        public IActionResult FindGrade(float score){
           
           string grade = "";
           if(score >= 80){
               grade = "A";
           }else if (score < 80 && score >= 75){
               grade = "B+";
           }else if (score < 75 && score >= 70){
               grade = "B";
           }else if (score < 70 && score >= 65){
               grade = "C+";
           }else if (score < 65 && score >= 60){
               grade = "C";
           }else if (score < 60 && score >= 55){
               grade = "D+";
           }else if (score < 55 && score >= 50){
               grade = "D";
           }else if (score < 50 ){
               grade = "F";
           }

           return Ok(grade);
        }

        [HttpPost]
         [Route("FindSquare")]
        public IActionResult FindSquare(double width , double length){
            double result = width * length;
            return Ok(result.ToString("F"));
        }


        [HttpPost]
        [Route("ConvertDate/Bud")]
        public IActionResult ConvertBud(int date,string mouth ,int year){
           
            string newMouth="";
            int newYear = 0 ;

        
            switch (mouth){
                  case "01" : newMouth = "มกราคม";break;
                  case "02" : newMouth = "กุมภาพันธ์";break;
                  case "03" : newMouth = "มีนาคม";break;
                  case "04" : newMouth = "เมษายน";break;
                  case "05" : newMouth = "พฤษภาคม";break;
                  case "06" : newMouth = "มิถุนายน";break;
                  case "07" : newMouth = "กรกฎาคม";break;
                  case "08" : newMouth = "สิงหาคม";break;
                  case "09" : newMouth = "กันยายน";break;
                  case "10" : newMouth = "ตุลาคม";break;
                  case "11" : newMouth = "พฤศจิกายน";break;
                  case "12" : newMouth = "ธันวาคม";break;
                
              }

              newYear = year + 543;

             string result = date + " " + newMouth + " " + newYear;

            return Ok(result);
        }


       [HttpGet("Now")]
        public IActionResult GetNow(string name)
        {
            var result = DateTime.Now;
            return Ok(result);
        }

         [HttpPost("PostFormModel")]
    public IActionResult PostFormModel(Book input)
    {
        var result = input;
            return Ok(result);
    }
      
    
      [HttpGet("SearchBooks")]
      public IActionResult SearchBooks(string search)
        {
            var searchResult = _db.Books.Where(x => x.Name.Contains(search)).First();
            return Ok(searchResult);
        }


    }
}