using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Order:BaseEntity
    {

        public int ReservationID { get; set; }

        public  decimal TotalPrice { get; set; }



        //Relational Properties
        public Reservation Reservation { get; set; }
        public virtual List<OrderProduct> OrderProducts { get; set; }


        public Order()
        {
            this.OrderProducts = new List<OrderProduct>();
        }

        public decimal CountTotalCost()
        {
            //Düzenlenecek.
            return TotalPrice;
        }
    }
}
