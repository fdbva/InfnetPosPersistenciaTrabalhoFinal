using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Sifiscon.Application.ViewModels;
using Sifiscon.Domain.Entities;
using Sifiscon.Domain.Services.Interfaces;

namespace Sifiscon.Application.AppServices.Interfaces
{
    public interface IBaseAppService<TEntity, TEntityViewModel> : IDisposable
        where TEntity : BaseEntity
        where TEntityViewModel : BaseViewModel
    {
        Task<TEntityViewModel> AddAsync(TEntityViewModel obj);
        Task<TEntityViewModel> FindAsync(Guid id);
        IEnumerable<TEntityViewModel> Where(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntityViewModel> QueryAllAsNoTracking();
        IEnumerable<TEntityViewModel> GetAll();
        TEntityViewModel Update(TEntityViewModel obj);
        Task RemoveAsync(Guid id);
        void Remove(TEntityViewModel obj);
        new void Dispose();
    }
}
