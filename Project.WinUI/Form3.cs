using Project.BLL.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form3 : Form
    {
        RoomRep _roomRep;
        GuestReservationRep _guestReservationRep;
        GuestRep _guestRep;
        public Form3(Reservation res)
        {
            InitializeComponent();
            _reservation = res; 
            _roomRep = new RoomRep();
            _guestReservationRep = new GuestReservationRep();
            _guestRep = new GuestRep();
        }
        Reservation _reservation;
        private void btnAddVisitorInfo_Click(object sender, EventArgs e)
        {
            Guest g = new Guest();
            g.FirstName = txtFirstName.Text; 
            g.LastName = txtLastName.Text;
            
            
            GuestReservation gr = new GuestReservation();
            gr.RoomNo = _selectedRoom.RoomNo;
            gr.Guest = g;
            gr.Reservation =_reservation;
            gr.ReservationID = _reservation.ID;
            gr.GuestID = g.ID;
            _guestRep.Add(g);
            _guestReservationRep.Add(gr);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (RoomReservation item in _reservation.RoomReservations) 
            {
                lstSelectedRooms.Items.Add(item.Room.RoomNo);
            }
            
        }
        Room _selectedRoom;
        private void lstSelectedRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstSelectedRooms.SelectedIndex > -1)
            {
                _selectedRoom = _roomRep.GetRoomByRoomNumber(lstSelectedRooms.SelectedItem.ToString());
                
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            
        }
    }
}
