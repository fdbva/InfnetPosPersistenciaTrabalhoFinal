using Sifiscon.Domain.DataInterfaces.Repositories;

namespace Sifiscon.Domain.Services.Interfaces
{
    public interface IBaseService<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        
    }
}
