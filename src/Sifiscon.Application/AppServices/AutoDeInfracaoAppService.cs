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
    public class AutoDeInfracaoAppService : BaseAppService<IAutoDeInfracaoService, AutoDeInfracao, AutoDeInfracaoViewModel>, IAutoDeInfracaoAppService
    {
        public AutoDeInfracaoAppService(IAutoDeInfracaoService repository, IUnitOfWork uow, IMapper mapper) : base(repository, uow, mapper)
        {
        }
    }
}
