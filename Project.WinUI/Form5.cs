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
    public partial class Form5 : Form
    {
        public Form5(List<Guest> guests)
        {
            foreach (Guest guest in guests)
            {
                if (guest.ToString() != string.Empty)
                {
                    lstGuests.Items.Add(guest);
                }
                else
                {
                    continue;
                }
            }
            InitializeComponent();
        }
    }
}
