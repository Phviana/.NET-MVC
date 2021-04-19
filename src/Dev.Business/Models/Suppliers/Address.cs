﻿using Dev.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Business.Models.Suppliers
{
    public class Address : Entity
    {
        public string AddressLineOne { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }

        //EF Realtions
        public Supplier Supplier { get; set; }
    }
}
