using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class HouseKeeper:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relational Properties

        public virtual List<HouseKeeperRoom> HouseKeeperRooms { get; set; }

        public HouseKeeper()
        {
            this.HouseKeeperRooms = new List<HouseKeeperRoom>();
        }
    }
}
