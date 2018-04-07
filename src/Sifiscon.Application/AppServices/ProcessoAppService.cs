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
    public class ProcessoAppService : BaseAppService<Processo, ProcessoViewModel>, IProcessoAppService
    {
        public ProcessoAppService(IBaseService<Processo> repository, IUnitOfWork uow) : base(repository, uow)
        {
        }
    }
}
