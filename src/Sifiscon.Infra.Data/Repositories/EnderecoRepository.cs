using Sifiscon.Domain.Entities;
using Sifiscon.Domain.Interfaces.Repositories;
using Sifiscon.Infra.Data.Context;

namespace Sifiscon.Infra.Data.Repositories
{
    public class EnderecoRepository : RepositoryBase<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(SifisconContext context) : base(context)
        {
        }
    }
}
