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
            cmbProduct.DataSource = _productRep.ListProducts();
            cmbRoomNo.DataSource = _roomRep.ListRoomNumbers();
        }

        decimal total;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderProduct op = new OrderProduct();
            op.Product = cmbProduct.SelectedItem as Product;
            op.RoomNo = _roomRep.GetRoomByRoomNumber(cmbRoomNo.SelectedItem.ToString()).RoomNo;

            

            listProduct.Items.Add($"{op.Product} => Oda:{op.RoomNo}");
          
            total += (cmbProduct.SelectedItem as Product).UnitPrice;
            

            lblTotal.Text = $"{total:C2}";

        }

      
        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            OrderProduct op = new OrderProduct();
            foreach (object item in listProduct.Items)
            {
                op = item as OrderProduct;
                order.OrderProducts.Add(op);
                _orderProductRep.Add(op);
                _orderRep.Add(order);

               Reservation res = _reservationRep.Find(Convert.ToInt32(_roomRep.GetRoomByRoomNumber(op.RoomNo)));
                res.Orders.Add(order);
                _reservationRep.Update(res);
                lblTotal.Text = "0";
                total = 0;
            }
        }
    }
}
