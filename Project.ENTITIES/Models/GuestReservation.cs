using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class GuestReservation:BaseEntity
    {
        public int ReservationID { get; set; }
        public int GuestID { get; set; }

        public string RoomNo { get; set; }

        //Relational Properties

        public virtual Reservation Reservation { get; set; }
        public virtual Guest Guest { get; set; }
    }
}
