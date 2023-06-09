﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

        //Relational Properties
        public virtual List<OrderProduct> OrderProducts { get; set; }


        public Product()
        {
            this.OrderProducts = new List<OrderProduct>();
        }

        public override string ToString()
        {
            return $"{ProductName} {UnitPrice:C2}";
        }
    }
}
