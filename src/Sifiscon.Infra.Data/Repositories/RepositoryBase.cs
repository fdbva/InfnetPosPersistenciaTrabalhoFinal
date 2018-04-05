using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sifiscon.Domain.Interfaces.Repositories;
using Sifiscon.Infra.Data.Context;

namespace Sifiscon.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected SifisconContext Ctx;
        protected DbSet<TEntity> DbSet;

        public RepositoryBase(SifisconContext context)
        {
            Ctx = context;
            DbSet = Ctx.Set<TEntity>();
        }

        public virtual async Task<TEntity> AddAsync(TEntity obj)
        {
            var entity = await DbSet.AddAsync(obj);
            return entity.Entity;
        }

        public virtual async Task<TEntity> FindAsync(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public virtual IEnumerable<TEntity> GetAllAsNoTracking()
        {
            return DbSet.AsNoTracking();
        }

        public virtual TEntity Update(TEntity obj)
        {
            var entry = Ctx.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;

            return obj;
        }

        public virtual void RemoveAsync(TEntity obj)
        {
            DbSet.Remove(obj);
        }

        public virtual async Task RemoveAsync(Guid id)
        {
            DbSet.Remove(await DbSet.FindAsync(id));
        }

        public void Dispose()
        {
            Ctx.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
