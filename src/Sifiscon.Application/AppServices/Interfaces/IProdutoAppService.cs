using Sifiscon.Application.ViewModels;
using Sifiscon.Domain.Entities;

namespace Sifiscon.Application.AppServices.Interfaces
{
    public interface IProdutoAppService : IBaseAppServiceInternal<Produto, ProdutoViewModel>, IBaseAppService<ProdutoViewModel>
    {

    }
}
