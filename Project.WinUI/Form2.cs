using Project.BLL.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form2 : Form
    {
        string _appUserName;
        AppUserRep _appUserRep;
        RoomRep _roomRep;
        public  Form2(/*string _appUserName*/)
        {
            InitializeComponent();
            _appUserRep = new AppUserRep();
            _roomRep = new RoomRep();
            //foreach (Char s in _appUserName)
            //{
            //   s.ToString();
            //    _appUserName = s.ToString();
            //}
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Room item in _roomRep.GetAll())
            {
                foreach (Control group  in this.Controls)
                {   
                    if(group is GroupBox)
                    foreach (Button panel in group.Controls)
                    {
                        if (item.RoomNo == (panel).Text)
                        {
                            panel.BackColor = item.RoomStatus == ENTITIES.Enums.RoomStatus.Available ? Color.Green : Color.Red;
                            if (item.RoomStatus == ENTITIES.Enums.RoomStatus.Available)
                            {
                                panel.BackColor = Color.Green;
                            }
                            else if (item.RoomStatus == ENTITIES.Enums.RoomStatus.Booked)
                            {
                                panel.BackColor = Color.Red;
                            }
                            else if (item.RoomStatus == ENTITIES.Enums.RoomStatus.Cleaning)
                            {
                                //Hizmetli metodu
                            }
                            if (panel.BackColor == Color.Red) panel.Enabled = false;
                            else if (panel.BackColor == Color.Orange) panel.Enabled = false;
                        }
                    }
                }
                
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.ReservationName = txtRegistrationName.Text;
            
            Reservation r = new Reservation();
            //foreach ( AppUser item in _appUserRep.GetAll())
            //{
            //    if (item.UserName == _appUserName) item.ReceptionPersonel = r.ReceptionPersonel;
            //}
            r.CheckInDate = dtpCheckIn.Value;
            r.CheckOutDate = dtpCheckOut.Value;
            r.Customer = c;
            
          
        }
    }
}
