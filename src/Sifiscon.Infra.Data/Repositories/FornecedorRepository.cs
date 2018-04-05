using Sifiscon.Domain.Entities;
using Sifiscon.Domain.Interfaces.Repositories;
using Sifiscon.Infra.Data.Context;

namespace Sifiscon.Infra.Data.Repositories
{
    public class FornecedorRepository : RepositoryBase<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(SifisconContext context) : base(context)
        {
        }
    }
}
