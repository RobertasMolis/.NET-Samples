using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public List<Room> Rooms { get; set; }
        public int? RoomId { get; set; }
        public int MaxRoomNumber { get; set; }
    }
}