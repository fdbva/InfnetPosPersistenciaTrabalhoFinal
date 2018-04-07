﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sifiscon.Domain.DataInterfaces.Repositories;
using Sifiscon.Domain.Entities;
using Sifiscon.Domain.Services.Interfaces;

namespace Sifiscon.Domain.Services
{
    public class AutoDeInfracaoService : BaseService<AutoDeInfracao>, IAutoDeInfracaoService
    {
        public AutoDeInfracaoService(IBaseRepository<AutoDeInfracao> repository) : base(repository)
        {
        }
    }
}
