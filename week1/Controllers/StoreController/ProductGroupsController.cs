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
    public class ProductGroupsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly AppDBContext _db;

        public ProductGroupsController(IMapper mapper,AppDBContext db){
            this._mapper = mapper;
            this._db = db;
        }

        [HttpGet("GetProductGroup")]
        public IActionResult GetProductGroup(){
            var productGroup = _db.ProductGroups.ToList();
            var result = _mapper.Map<List<ProductGroupDTO_ToReturn>>(productGroup);
            return Ok(result);
        }

         [HttpGet("GetProductGroupById/{id}")]
        public IActionResult GetProductGroupById(int id){
            var productGroup = _db.ProductGroups.Where(x => x.Id == id).FirstOrDefault();
            var result = _mapper.Map<ProductGroupDTO_ToReturn>(productGroup);
            return Ok(result);
        }

        [HttpPost("InsertProductGroup")]
        public IActionResult InsertProductGroup(ProductGroupDTO_ToCreate input){
            var productGroup = new ProductGroup();

            productGroup.Name = input.Name;
            productGroup.GroupCode = input.GroupCode;
            productGroup.CreateDate = DateTime.Now;
            _db.ProductGroups.Add(productGroup);
            _db.SaveChanges();

            var result = _mapper.Map<ProductGroupDTO_ToReturn>(productGroup);
            return Ok(result);
        }

        [HttpPut("EditProductGroup/{id}")]
        public IActionResult EditProductGroup(ProductGroupDTO_ToUpdate input ,int id){
            var productGroup = _db.ProductGroups.Where(x => x.Id == id).FirstOrDefault();

            if(productGroup == null){
                return NotFound("Not value id: "+id);
            }else{
                productGroup.Name = input.Name;
                productGroup.GroupCode = input.GroupCode;
                _db.SaveChanges();
                
                var result = _mapper.Map<ProductGroupDTO_ToReturn>(productGroup);
                return Ok(result);
            }
        }

        [HttpGet("GetProductByProductGroupId")]
        public IActionResult GetProductByProductGroupId(int id){
            
            var product = _db.ProductGroups.Include(x => x.Product).Where(x => x.Id == id).ToList();
            var result = _mapper.Map<List<ProductGroupDTO_ToReturn_Product>>(product);
            return Ok(result);
        }
    }
}