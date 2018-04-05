using Sifiscon.Domain.Entities;
using Sifiscon.Domain.Interfaces.Repositories;
using Sifiscon.Infra.Data.Context;

namespace Sifiscon.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public ProdutoRepository(SifisconContext context) : base(context)
        {
        }
    }
}
