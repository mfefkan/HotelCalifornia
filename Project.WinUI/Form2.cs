﻿using Project.BLL.GenericRepository.ConcRep;
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
        ReservationRep _reservationRep;
        GuestRep _guestRep;
        public  Form2(/*string _appUserName*/)
        {
            _appUserRep = new AppUserRep();
            _roomRep = new RoomRep();
            _reservationRep = new ReservationRep();
            _guestRep = new GuestRep();
            InitializeComponent();
            
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
            //foreach (AppUser item in _appUserRep.GetAll())
            //{
            //    if (item.UserName == _appUserName)
            //    {
            //        r.ReceptionPersonel = item.ReceptionPersonel;
            //        r.ReceptionPersonelID = item.ReceptionPersonel.ID;
            //    }
            //}
            r.CheckInDate = dtpCheckIn.Value;
            r.CheckOutDate = dtpCheckOut.Value;
            r.Customer = c;
            r.CustomerID = c.ID;
            c.Reservations.Add(r);
            
          
        }

        private void btnSearchRes_Click(object sender, EventArgs e)
        {
           Reservation res = _reservationRep.GetReservationByReservationName(txtRegistrationName.Text);
            if(res != null)
            {
                Form frm3 = new Form3(res);
                frm3.ShowDialog();
            }
            
        }

        private void btnRoomService_Click(object sender, EventArgs e)
        {
            Form frm4 = new Form4();
            frm4.ShowDialog();
        }

        private void btnGuestList_Click(object sender, EventArgs e)
        {
            Form frm5 = new Form5(_guestRep.GetActives().ToList());
            frm5.ShowDialog();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Reservation res = _reservationRep.GetReservationByReservationName(txtRegistrationName.Text);
            if (res != null)
            {
                
                res.CheckOutDate= DateTime.Now;
                _reservationRep.Update(res);
                _reservationRep.Delete(res);

                // devam edilecek
            }
        }
    }
}
