﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ReceptionPersonel:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relational Properties
        public virtual AppUser AppUser { get; set; }
        public virtual List<Reservation> Reservations { get; set; }

        public ReceptionPersonel()
        {
            this.Reservations = new List<Reservation>();
        }
    }
}
