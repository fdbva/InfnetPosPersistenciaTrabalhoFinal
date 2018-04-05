using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sifiscon.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<TEntity> AddAsync(TEntity obj);
        Task<TEntity> FindAsync(int id);
        IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetAllAsNoTracking();
        TEntity Update(TEntity obj);
        Task RemoveAsync(Guid id);
        void RemoveAsync(TEntity obj);
        void Dispose();
    }
}
