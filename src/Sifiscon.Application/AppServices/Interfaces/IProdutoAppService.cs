using Sifiscon.Application.ViewModels;
using Sifiscon.Domain.Entities;

namespace Sifiscon.Application.AppServices.Interfaces
{
    public interface IProdutoAppService : IBaseAppService2<Produto, ProdutoViewModel>, IBaseAppService<ProdutoViewModel>
    {

    }
}
