using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Sifiscon.Domain.DataInterfaces.Repositories
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        Task<TEntity> AddAsync(TEntity obj);
        Task<TEntity> FindAsync(Guid id);
        IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> QueryAllAsNoTracking();
        TEntity Update(TEntity obj);
        Task RemoveAsync(Guid id);
        void Remove(TEntity obj);
        new void Dispose();
    }
}
