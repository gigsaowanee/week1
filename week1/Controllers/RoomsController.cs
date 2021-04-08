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
    public class RoomsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly AppDBContext _db;

        public RoomsController( IMapper mapper,AppDBContext db){
            this._mapper = mapper;
            this._db = db;
        }

        [HttpGet("GetAllRoom")]
        public IActionResult GetRoomTotal(){
        var roomList = _db.Rooms.ToList();
        int total = roomList.Count();
        var detail = _mapper.Map<List<RoomDTO_ToReturn>>(roomList);
        
        var room = new RoomDTO_ToReturn_Summary();
        
        room.TotalRooms = total;
        room.Detail = detail;
        return Ok(room);
        }

    }
}