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
    public class ProductsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly AppDBContext _db;

        public ProductsController(IMapper mapper,AppDBContext db){
            this._mapper = mapper;
            this._db = db;
        }

        [HttpGet("GetProduct")]
        public IActionResult GetProduct(){
            var product = _db.Products.Include(x => x.ProductGroup).ToList();
            var result = _mapper.Map<List<ProductDTO_ToReturn>>(product);
            return Ok(result);
        }

        [HttpGet("GetProductById/{id}")]
        public IActionResult GetProductById(int id){
            var product = _db.Products.Include(x => x.ProductGroup).Where(x => x.Id == id).FirstOrDefault();
            var result = _mapper.Map<ProductDTO_ToReturn>(product);
            return Ok(result);
        }

        [HttpPost("InsertProduct")]
        public IActionResult InsertProduct(ProductDTO_ToCreate input){
            var product = new Product();

            product.Name = input.Name;
            product.Price = input.Price;
            product.ProductGroupId = input.ProductGroupId;
            product.NumberOfProduct = input.NumberOfProduct;
            product.CreateDate = DateTime.Now;

            _db.Products.Add(product);
            _db.SaveChanges();

            var result = _mapper.Map<ProductDTO_ToReturn>(product);
            return Ok(result);
        }

        [HttpPut("EditProduct/{id}")]
        public IActionResult EditProduct(ProductDTO_ToUpdate input ,int id){
            var product = _db.Products.Where(x => x.Id == id).FirstOrDefault();

        if(product == null)
        {
            return NotFound("Not found value of id " + id);
        }else
        {
            product.Name = input.Name;
            product.Price = input.Price;
            product.ProductGroupId = input.ProductGroupId;
            product.NumberOfProduct = input.NumberOfProduct;
            product.CreateDate = DateTime.Now;

            _db.SaveChanges();

            var result =  _mapper.Map<ProductDTO_ToReturn>(product);
            return Ok(result);
        }
        }

     
        
    }
}