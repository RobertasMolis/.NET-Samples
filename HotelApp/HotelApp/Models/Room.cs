using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Models
{
    public class Room : Entity
    {
        public int Floor { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public int RoomNumber { get; set; }
        public bool IsBooked { get; set; }
    }
}
