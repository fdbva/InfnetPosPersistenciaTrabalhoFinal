using Sifiscon.Domain.Entities;
using Sifiscon.Domain.Interfaces.Repositories;
using Sifiscon.Infra.Data.Context;

namespace Sifiscon.Infra.Data.Repositories
{
    public class AutoDeInfracaoRepository : RepositoryBase<AutoDeInfracao>, IAutoDeInfracaoRepository
    {
        public AutoDeInfracaoRepository(SifisconContext context) : base(context)
        {
        }
    }
}
