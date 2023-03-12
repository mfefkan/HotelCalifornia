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
        List<Guest> g = new List<Guest>();
        public Form5(List<Guest> guests)
        {
            foreach (Guest guest in guests)
            {

                g.Add(guest);

            }
            InitializeComponent();

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            foreach (Guest item in g)
            {
                lstGuests.Items.Add(item);
            }
        }
    }
}
