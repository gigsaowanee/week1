using System.Collections.Generic;

namespace week1.DTOs
{
    public class RoomDTO_ToReturn_Summary
    {
        public int TotalRooms { get; set; }
        public List<RoomDTO_ToReturn> Detail { get; set; }
    }
}