﻿using Sifiscon.Domain.DataInterfaces.Repositories;
using Sifiscon.Domain.Entities;
using Sifiscon.Infra.Data.Context;

namespace Sifiscon.Infra.Data.Repositories
{
    public class FornecedorRepository : BaseRepository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(SifisconContext context) : base(context)
        {
        }
    }
}
