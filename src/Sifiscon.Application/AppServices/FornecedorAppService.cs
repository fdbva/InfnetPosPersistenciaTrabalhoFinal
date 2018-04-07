using System;
using System.Collections.Generic;
using System.Linq;
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
    public class FornecedorAppService : BaseAppService<IFornecedorService, Fornecedor, FornecedorViewModel>, IFornecedorAppService
    {
        public FornecedorAppService(IFornecedorService repository, IUnitOfWork uow, IMapper mapper) : base(repository, uow, mapper)
        {
        }
    }
}
