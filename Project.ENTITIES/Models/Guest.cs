using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Guest:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relational Properties

        public virtual List<GuestReservation> GuestReservations { get; set; }

        public Guest()
        {
            this.GuestReservations = new List<GuestReservation>();
        }

        public override string ToString()
        {
            string info = string.Empty;
            foreach (GuestReservation item in GuestReservations)
            {
                
                if (item.DeletedDate == null)
                {
                    info = $"{FirstName} {LastName} => Room:{item.RoomNo}";
                }
                else
                {
                    continue;
                }
            }
            return info;
        }
    }
}
