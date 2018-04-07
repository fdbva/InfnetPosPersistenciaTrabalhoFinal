using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sifiscon.Application.AppServices.Interfaces;
using Sifiscon.Application.ViewModels;
using Sifiscon.Domain.DataInterfaces.UoW;
using Sifiscon.Domain.Entities;
using Sifiscon.Domain.Services.Interfaces;

namespace Sifiscon.Application.AppServices
{
    public class EnderecoAppService : BaseAppService<Endereco, EnderecoViewModel>, IEnderecoAppService
    {
        public EnderecoAppService(IBaseService<Endereco> repository, IUnitOfWork uow) : base(repository, uow)
        {
        }
    }
}
