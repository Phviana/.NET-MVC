using Dev.Business.Core.Data;
using Dev.Business.Core.Models;
using Dev.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Infra.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {

        protected readonly MyDBContext Db;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository()
        {
            Db = new MyDBContext();
            DbSet = Db.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task<TEntity> GetById(Guid Id)
        {
            return await DbSet.FindAsync(Id);
        }

        public virtual async Task Insert(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }

        public virtual async Task Update(TEntity entity)
        {
            Db.Entry(entity).State = EntityState.Modified;
            await SaveChanges();
        }

        public virtual async Task Delete(Guid Id)
        {
            Db.Entry(new TEntity { Id = Id }).State = EntityState.Deleted;
            await SaveChanges();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
