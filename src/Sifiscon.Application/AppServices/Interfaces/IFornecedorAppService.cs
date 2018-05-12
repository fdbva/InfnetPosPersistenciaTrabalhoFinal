using Sifiscon.Application.ViewModels;
using Sifiscon.Domain.Entities;

namespace Sifiscon.Application.AppServices.Interfaces
{
    public interface IFornecedorAppService : IBaseAppService2<Fornecedor, FornecedorViewModel>, IBaseAppService<FornecedorViewModel>
    {

    }
}
