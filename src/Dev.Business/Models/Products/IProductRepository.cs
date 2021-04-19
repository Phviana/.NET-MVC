using Dev.Business.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Business.Models.Products
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsBySupplier(Guid supplierId);
        Task<IEnumerable<Product>> GetProductsSuppliers(Guid supplierId);
        Task<Product> GetProductsSupplier(Guid supplierId);
    }
}
