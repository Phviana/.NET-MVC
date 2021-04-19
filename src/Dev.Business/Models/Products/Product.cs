using Dev.Business.Core.Models;
using Dev.Business.Models.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Business.Models.Products
{
    public class Product : Entity
    {
        public Guid SupplierId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Value { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool Active { get; set; }

        //EF Realtions
        public Supplier Supplier { get; set; }
    }
}
