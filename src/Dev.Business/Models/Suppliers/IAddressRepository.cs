using Dev.Business.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Business.Models.Suppliers
{
    public interface IAddressRepository : IRepository<Address>
    {
        Task<Address> GetAddressBySupplier(Guid supplierId);
    }
}
