using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Room:BaseEntity
    {
        public string RoomNo { get; set; }
        public string Description { get; set; }
        public int ReservationID { get; set; }

        public RoomStatus RoomStatus { get; set; }

        public int RoomTypeID { get; set; }

        public decimal  PricePerDay { get; set; }

        //Relational 
        public virtual List<RoomReservation> RoomReservations { get; set; }
        public virtual RoomType RoomType { get; set; }

        public virtual List<HouseKeeperRoom> HouseKeeperRooms { get; set; }

        public Room()
        {
            RoomStatus = RoomStatus.Available;
            this.HouseKeeperRooms = new List<HouseKeeperRoom>();
        }

        public override string ToString()
        {
            return $"Room No:{RoomNo}, {Description}";
        }
    }
}
