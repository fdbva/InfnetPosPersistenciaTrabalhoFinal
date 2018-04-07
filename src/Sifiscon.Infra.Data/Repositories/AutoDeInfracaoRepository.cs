using Sifiscon.Domain.DataInterfaces.Repositories;
using Sifiscon.Domain.Entities;
using Sifiscon.Infra.Data.Context;

namespace Sifiscon.Infra.Data.Repositories
{
    public class AutoDeInfracaoRepository : BaseRepository<AutoDeInfracao>, IAutoDeInfracaoRepository
    {
        public AutoDeInfracaoRepository(SifisconContext context) : base(context)
        {
        }
    }
}
