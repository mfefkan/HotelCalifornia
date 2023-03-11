using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class HouseKeeperRoom:BaseEntity
    {

        public int RoomID { get; set; }
        public int HouseKeeperID { get; set; }
 

        //Relational Properties

        public virtual HouseKeeper HouseKeeper { get; set; }
        public virtual Room Room { get; set; }
    }
}
