using Project.BLL.GenericRepository.BaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.GenericRepository.ConcRep
{
    public class RoomRep:BaseRep<Room>
    {
        public List<string> ListRoomNumbers()
        {
            List<string> list = new List<string>();
            foreach (Room item in _db.Rooms.ToList())
            {
                list.Add(item.RoomNo);
            }
            return list;
        }

        public Room GetRoomByRoomNumber(string roomNumber)
        {
            Room room = null;
            foreach (Room item in _db.Rooms.Where(x => x.RoomNo == roomNumber).ToList())
            {
                room = item;
            }
            return room;
            
        }
    }

   
}
