using Sifiscon.Domain.DataInterfaces.Repositories;
using Sifiscon.Domain.Entities;
using Sifiscon.Infra.Data.Context;

namespace Sifiscon.Infra.Data.Repositories
{
    public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(SifisconContext context) : base(context)
        {
        }
    }
}
