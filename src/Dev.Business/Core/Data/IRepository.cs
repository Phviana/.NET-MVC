using Dev.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Business.Core.Data
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task Insert(TEntity entity);
        Task<TEntity> GetById(Guid Id);
        Task<List<TEntity>> GetAll();
        Task Update(TEntity entity);
        Task Delete(Guid Id);
        Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveChanges();
    }
}
