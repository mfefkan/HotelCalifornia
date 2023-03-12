using Project.BLL.GenericRepository.BaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.GenericRepository.ConcRep
{
    public class HouseKeeperRep:BaseRep<HouseKeeper>
    {
        public void CleanRoom(string roomNo)
        {
            foreach (Room item in _db.Rooms)
            {
                if(item.RoomNo == roomNo)
                {
                    item.RoomStatus = ENTITIES.Enums.RoomStatus.Available;
                    System.Windows.Forms.MessageBox.Show("The room cleaned.");
                    break;
                }
                
            }
        }
    }
}
