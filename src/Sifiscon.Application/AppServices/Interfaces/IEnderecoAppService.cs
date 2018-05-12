using Sifiscon.Application.ViewModels;
using Sifiscon.Domain.Entities;

namespace Sifiscon.Application.AppServices.Interfaces
{
    public interface IEnderecoAppService : IBaseAppService2<Endereco, EnderecoViewModel>, IBaseAppService<EnderecoViewModel>
    {

    }
}
