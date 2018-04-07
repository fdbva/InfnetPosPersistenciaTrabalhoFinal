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
    public class FornecedorAppService : BaseAppService<Fornecedor, FornecedorViewModel>, IFornecedorAppService
    {
        public FornecedorAppService(IBaseService<Fornecedor> repository, IUnitOfWork uow) : base(repository, uow)
        {
        }
    }
}
