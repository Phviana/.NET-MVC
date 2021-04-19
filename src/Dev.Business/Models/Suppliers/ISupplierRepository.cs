using Dev.Business.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Business.Models.Suppliers
{
    public interface ISupplierRepository : IRepository<Supplier>
    {
        Task<Supplier> GetSupplierAddress(Guid id);
        Task<Supplier> GetSupplierAddressProducts(Guid id);
    }
}
