using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Reservation:BaseEntity
    {
        public string CustomerName { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public int CustomerID { get; set; }
        public int ReceptionPersonelID { get; set; }

        //Relational Properties
        public virtual List<RoomReservation> RoomReservations { get; set; }
        public virtual List<GuestReservation> GuestReservations { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ReceptionPersonel ReceptionPersonel { get; set; }
        public virtual List<Order> Orders { get; set; }

        public Reservation()
        {
            this.RoomReservations = new List<RoomReservation>();
            this.GuestReservations = new List<GuestReservation>();
            this.Orders = new List<Order>();
        }
    }
}
