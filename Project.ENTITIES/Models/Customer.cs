using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Customer:BaseEntity
    {
        public string ReservationName { get; set; }



        //Relational Properties
        public virtual List<Reservation> Reservations { get; set; }



        public Customer()
        {
            this.Reservations = new List<Reservation>();
        }
    }
}
