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
    public partial class Form4 : Form
    {
        ProductRep _productRep;
        OrderRep _orderRep;
        RoomRep _roomRep;
        OrderProductRep _orderProductRep;
        ReservationRep _reservationRep;
        public Form4()
        {
            _productRep = new ProductRep();
            _orderRep = new OrderRep();
            _roomRep = new RoomRep();
            _orderProductRep = new OrderProductRep();
            _reservationRep = new ReservationRep();
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cmbProduct.DataSource = _productRep.GetAll();
            cmbRoomNo.DataSource = _roomRep.ListRoomNumbers();
        }

        decimal total;
        private void btnAdd_Click(object sender, EventArgs e)
        {

            //OrderProduct op = new OrderProduct();
            //op.Product = cmbProduct.SelectedItem as Product;
            //op.RoomNo = _roomRep.GetRoomByRoomNumber(cmbRoomNo.SelectedItem.ToString()).RoomNo;



            listProduct.Items.Add(cmbProduct.SelectedItem as Product);
          
            //total += (cmbProduct.SelectedItem as Product).UnitPrice;
            

            lblTotal.Text = $"{total:C2}";

        }

      
        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
           
            
            foreach (Product item in listProduct.Items)
            {
                OrderProduct op = new OrderProduct();
                op.Order = order;
                op.Product=item;
                order.OrderProducts.Add(op);
                op.RoomNo = cmbRoomNo.SelectedItem.ToString();
                //op = item as OrderProduct;
                //order.OrderProducts.Add(op);
                //_orderProductRep.Add(op);
                //_orderRep.Add(order);

               
                // lblTotal.Text = "0";
                // total = 0;
            }

            foreach (Reservation item in _reservationRep.GetActives())
            {
                if (item.RoomReservations.Any(x => x.Room.RoomNo == cmbRoomNo.SelectedItem.ToString()))
                {
                    item.Orders.Add(order);
                    //_reservationRep.Update(item);
                    break;
                }
            }

            //Reservation res = _reservationRep.Find(Convert.ToInt32(_roomRep.GetRoomByRoomNumber(cmbRoomNo.SelectedItem.ToString())));
            //res.Orders.Add(order);
          
            //_orderRep.Add(order);
        }
    }
}
