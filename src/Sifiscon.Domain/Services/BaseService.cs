using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Sifiscon.Domain.DataInterfaces.Repositories;
using Sifiscon.Domain.Services.Interfaces;

namespace Sifiscon.Domain.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual Task<TEntity> AddAsync(TEntity obj)
        {
            return _repository.AddAsync(obj);
        }

        public virtual Task<TEntity> FindAsync(Guid id)
        {
            return _repository.FindAsync(id);
        }

        public virtual IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return _repository.Where(predicate);
        }

        public virtual IQueryable<TEntity> QueryAllAsNoTracking()
        {
            return _repository.QueryAllAsNoTracking();
        }

        public virtual TEntity Update(TEntity obj)
        {
            return _repository.Update(obj);
        }

        public virtual Task RemoveAsync(Guid id)
        {
            return _repository.RemoveAsync(id);
        }

        public virtual void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public virtual void Dispose()
        {
            _repository.Dispose();
        }
    }
}
