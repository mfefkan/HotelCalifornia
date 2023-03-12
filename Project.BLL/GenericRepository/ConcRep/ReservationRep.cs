using Project.BLL.GenericRepository.BaseRep;
using Project.DAL.ContextClasses;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.BLL.GenericRepository.ConcRep
{
    public class ReservationRep:BaseRep<Reservation>
    {
        public Reservation GetReservationByReservationName(string reservationName)
        {
            Reservation reservation = new Reservation();    
            if (_db.Reservations.Any(x => x.CustomerName == reservationName))
            {
                foreach (Reservation item in _db.Reservations.Where(x => x.CustomerName == reservationName))
                {
                    reservation = item;
                    break;
                }
            }
            else
            {
                throw new Exception("Aradığınız isme ait rezervasyon bulunamadı");
            }
            return reservation;
        }
    }
}
