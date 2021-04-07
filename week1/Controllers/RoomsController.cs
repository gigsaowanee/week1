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
    public class RoomsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private List<Room> roomList = new List<Room>();
        
        public RoomsController( IMapper mapper){
            roomList.Add(new Room() { Id= 1 , RoomId = "A1" , Type = "Single" ,People = 1 , Floor = 2 });
            roomList.Add(new Room() { Id= 2 , RoomId = "B4" , Type = "Double" ,People = 2 , Floor = 3 });
            roomList.Add(new Room() { Id= 3 , RoomId = "C3" , Type = "Triple" ,People = 3 , Floor = 1 });
            roomList.Add(new Room() { Id= 4 , RoomId = "A3" , Type = "Single" ,People = 1 , Floor = 2 });
            roomList.Add(new Room() { Id= 5 , RoomId = "A8" , Type = "Single" ,People = 1 , Floor = 2 });
            this._mapper = mapper;
        }

        [HttpGet("GetAllRoom")]
        public IActionResult GetRoomTotal(){
            
        int total = roomList.Count();
        var detail = _mapper.Map<List<RoomDTO_ToReturn>>(roomList);
        
        var room = new RoomDTO_ToReturn_Summary();
        
        room.TotalRooms = total;
        room.Detail = detail;
        return Ok(room);
        }

    }
}