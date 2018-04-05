using Sifiscon.Domain.Entities;
using Sifiscon.Domain.Interfaces.Repositories;
using Sifiscon.Infra.Data.Context;

namespace Sifiscon.Infra.Data.Repositories
{
    public class ProcessoRepository : RepositoryBase<Processo>, IProcessoRepository
    {
        public ProcessoRepository(SifisconContext context) : base(context)
        {
        }
    }
}
