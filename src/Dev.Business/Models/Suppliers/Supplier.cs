using Dev.Business.Core.Models;
using Dev.Business.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Business.Models.Suppliers
{
    public class Supplier : Entity
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public SupplierType SupplierType { get; set; }
        public Address Address { get; set; }
        public bool Active { get; set; }

        //EF Realtions
        public ICollection<Product> Products { get; set; }

    }
}
