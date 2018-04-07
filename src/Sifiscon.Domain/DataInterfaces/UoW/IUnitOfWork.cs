using System.Threading.Tasks;

namespace Sifiscon.Domain.DataInterfaces.UoW
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        Task CommitAsync();
        void Commit();
    }
}
