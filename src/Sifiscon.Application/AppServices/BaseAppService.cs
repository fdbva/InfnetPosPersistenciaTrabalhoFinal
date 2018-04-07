using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Sifiscon.Application.AppServices.Interfaces;
using Sifiscon.Application.ViewModels;
using Sifiscon.Domain.DataInterfaces.UoW;
using Sifiscon.Domain.Entities;
using Sifiscon.Domain.Services.Interfaces;

namespace Sifiscon.Application.AppServices
{
    public class BaseAppService<TEntity, TEntityViewModel> : IBaseAppService<TEntity, TEntityViewModel> 
        where TEntity : BaseEntity
        where TEntityViewModel : BaseViewModel
    {
        private readonly IBaseService<TEntity> _baseService;
        private readonly IUnitOfWork _uow;

        public BaseAppService(IBaseService<TEntity> baseService, IUnitOfWork uow)
        {
            _baseService = baseService;
            _uow = uow;
        }

        public virtual Task<TEntityViewModel> AddAsync(TEntityViewModel obj)
        {
            _uow.BeginTransaction();
            var ret = _baseService.AddAsync(Mapper.Map<TEntity>(obj));
            _uow.CommitAsync();
            return Mapper.Map<Task<TEntityViewModel>>(ret);
        }

        public virtual Task<TEntityViewModel> FindAsync(Guid id)
        {
            return Mapper.Map<Task<TEntityViewModel>>(_baseService.FindAsync(id));
        }

        public virtual IEnumerable<TEntityViewModel> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return Mapper.Map<IEnumerable<TEntityViewModel>>(_baseService.Where(predicate));
        }

        public virtual IQueryable<TEntityViewModel> QueryAllAsNoTracking()
        {
            return Mapper.Map<IQueryable<TEntityViewModel>>(_baseService.QueryAllAsNoTracking());
        }

        public IEnumerable<TEntityViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<TEntityViewModel>>(_baseService.QueryAllAsNoTracking().ToList());
        }

        public virtual TEntityViewModel Update(TEntityViewModel obj)
        {
            _uow.BeginTransaction();
            var ret = _baseService.Update(Mapper.Map<TEntity>(obj));
            _uow.Commit();
            return Mapper.Map<TEntityViewModel>(ret);
        }

        public virtual Task RemoveAsync(Guid id)
        {
            _uow.BeginTransaction();
            var ret = _baseService.RemoveAsync(id);
            _uow.CommitAsync();
            return ret;
        }

        public virtual void Remove(TEntityViewModel obj)
        {
            _uow.BeginTransaction();
            _baseService.Remove(Mapper.Map<TEntity>(obj));
            _uow.CommitAsync();
        }

        public virtual void Dispose()
        {
            _baseService.Dispose();
        }
    }
}
