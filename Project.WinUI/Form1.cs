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
    public partial class Form1 : Form
    {
        AppUserRep _appUserRep;
        RoomRep _roomRep;
        RoomTypeRep _roomTypeRep;
        ReceptionPersonelRep _receptionPersonelRep;
        HouseKeeperRep _houseKeeperRep;
        ProductRep _productRep;
        public Form1()
        {
            InitializeComponent();
            _appUserRep = new AppUserRep();
            _roomRep = new RoomRep();
            _roomTypeRep = new RoomTypeRep();
            _receptionPersonelRep = new ReceptionPersonelRep();
            _houseKeeperRep = new HouseKeeperRep();
            _productRep = new ProductRep();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_appUserRep.Any(x => x.UserName == txtUserName.Text && x.Password == txtPassword.Text))
            {
                string a = txtUserName.Text;
                Form frm2 = new Form2(a);
                frm2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifreniz yanlış. Lütfen kontrol edip tekrar giriş yapmayı deneyiniz.");
                return;
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            Add2PeopleRoomTypeAnd10Room();
            btnAddRoom.BackColor = Color.Green;
        }

        private void Add2PeopleRoomTypeAnd10Room()
        {
            RoomType twoPeople = new RoomType();
            twoPeople.Description = "2 Kişilik mükemmel oda";

            _roomTypeRep.Add(twoPeople);

            Room x = new Room
            {
                RoomNo = "101",
                Description = "Güzel oda",
                PricePerDay = Convert.ToDecimal(20)
            };
            Room x1 = new Room
            {
                RoomNo = "102",
                Description = "Güzel oda",
                PricePerDay = 20
            };
            Room x2 = new Room
            {
                RoomNo = "103",
                Description = "Güzel oda",
                PricePerDay = 20
            };
            Room x3 = new Room
            {
                RoomNo = "104",
                Description = "Güzel oda",
                PricePerDay = 20
            };
            Room x4 = new Room
            {
                RoomNo = "105",
                Description = "Güzel oda",
                PricePerDay = 20
            };
            Room x5 = new Room
            {
                RoomNo = "106",
                Description = "Güzel oda",
                PricePerDay = 20
            };
            Room x6 = new Room
            {
                RoomNo = "107",
                Description = "Güzel oda",
                PricePerDay = 20
            };
            Room x7 = new Room
            {
                RoomNo = "108",
                Description = "Güzel oda",
                PricePerDay = 20
            };
            Room x8 = new Room
            {
                RoomNo = "109",
                Description = "Güzel oda",
                PricePerDay = 20
            };
            Room x9 = new Room
            {
                RoomNo = "110",
                Description = "Güzel oda",
                PricePerDay = 20
            };

            twoPeople.Rooms.Add(x);
            twoPeople.Rooms.Add(x1);
            twoPeople.Rooms.Add(x2);
            twoPeople.Rooms.Add(x3);
            twoPeople.Rooms.Add(x4);
            twoPeople.Rooms.Add(x5);
            twoPeople.Rooms.Add(x6);
            twoPeople.Rooms.Add(x7);
            twoPeople.Rooms.Add(x8);
            twoPeople.Rooms.Add(x9);
        }

        private void Add4PeopleRoomTypeAnd10Room()
        {
            RoomType forPeople = new RoomType();
            forPeople.Description = "4 Kişilik mükemmel bir oda...";

            _roomTypeRep.Add(forPeople);

            Room y = new Room
            {
                RoomNo = "111",
                Description = "Güzel oda",
                PricePerDay = Convert.ToDecimal(35)
            };
            Room y1 = new Room
            {
                RoomNo = "112",
                Description = "Güzel oda",
                PricePerDay = Convert.ToDecimal(35)
            };
            Room y2 = new Room
            {
                RoomNo = "113",
                Description = "Güzel oda",
                PricePerDay = Convert.ToDecimal(35)
            };
            Room y3 = new Room
            {
                RoomNo = "114",
                Description = "Güzel oda",
                PricePerDay = Convert.ToDecimal(35)
            };
            Room y4 = new Room
            {
                RoomNo = "115",
                Description = "Güzel oda",
                PricePerDay = Convert.ToDecimal(35)
            };
            Room y5 = new Room
            {
                RoomNo = "116",
                Description = "Güzel oda",
                PricePerDay = Convert.ToDecimal(35)
            };
            Room y6 = new Room
            {
                RoomNo = "117",
                Description = "Güzel oda",
                PricePerDay = Convert.ToDecimal(35)
            };
            Room y7 = new Room
            {
                RoomNo = "118",
                Description = "Güzel oda",
                PricePerDay = Convert.ToDecimal(35)
            };
            Room y8 = new Room
            {
                RoomNo = "119",
                Description = "Güzel oda",
                PricePerDay = Convert.ToDecimal(35)
            };
            Room y9 = new Room
            {
                RoomNo = "120",
                Description = "Güzel oda",
                PricePerDay = Convert.ToDecimal(35)
            };

            forPeople.Rooms.Add(y);
            forPeople.Rooms.Add(y1);
            forPeople.Rooms.Add(y2);
            forPeople.Rooms.Add(y3);
            forPeople.Rooms.Add(y4);
            forPeople.Rooms.Add(y5);
            forPeople.Rooms.Add(y6);
            forPeople.Rooms.Add(y7);
            forPeople.Rooms.Add(y8);
            forPeople.Rooms.Add(y9);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Add4PeopleRoomTypeAnd10Room();
            button1.BackColor = Color.Green;
        }

        private void btnAddAppUser_Click(object sender, EventArgs e)
        {
            AppUser user = new AppUser();
            ReceptionPersonel receptionPersonel = new ReceptionPersonel();
            user.ReceptionPersonel = receptionPersonel;
            
            user.UserName = "";
            user.Password = "";
            receptionPersonel.FirstName = "Hacı Muro";
            receptionPersonel.LastName = "Türkoğlu";
           
            _appUserRep.Add(user);
            _receptionPersonelRep.Add(receptionPersonel);
            btnAddAppUser.BackColor = Color.Green;

        }

        private void btnAddHouseKeeper_Click(object sender, EventArgs e)
        {
            HouseKeeper houseKeeper = new HouseKeeper();
            houseKeeper.FirstName = "leyligül";
            houseKeeper.LastName = "koşgetir";
            _houseKeeperRep.Add(houseKeeper);
            btnAddHouseKeeper.BackColor = Color.Green;
            
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product x = new Product();
            x.ProductName = "Mantı";
            x.UnitPrice = Convert.ToDecimal(4);
            _productRep.Add(x);
            
            
            Product y = new Product();
            y.ProductName = "Köfte";
            y.UnitPrice = Convert.ToDecimal(5);
            _productRep.Add(y);

            Product z = new Product();
            z.ProductName = "Kola";
            z.UnitPrice = Convert.ToDecimal(0.5);
            _productRep.Add(z);

            btnAddProduct.BackColor = Color.Green;
        }

    }




    }

