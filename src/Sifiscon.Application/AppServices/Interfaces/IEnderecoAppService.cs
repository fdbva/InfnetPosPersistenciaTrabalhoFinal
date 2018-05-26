using Sifiscon.Application.ViewModels;
using Sifiscon.Domain.Entities;

namespace Sifiscon.Application.AppServices.Interfaces
{
    public interface IEnderecoAppService : IBaseAppServiceInternal<Endereco, EnderecoViewModel>, IBaseAppService<EnderecoViewModel>
    {

    }
}
