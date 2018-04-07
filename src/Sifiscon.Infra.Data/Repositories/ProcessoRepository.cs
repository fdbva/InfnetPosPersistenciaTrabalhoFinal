using Sifiscon.Domain.DataInterfaces.Repositories;
using Sifiscon.Domain.Entities;
using Sifiscon.Infra.Data.Context;

namespace Sifiscon.Infra.Data.Repositories
{
    public class ProcessoRepository : BaseRepository<Processo>, IProcessoRepository
    {
        public ProcessoRepository(SifisconContext context) : base(context)
        {
        }
    }
}
