using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sifiscon.Domain.Entities;

namespace Sifiscon.Infra.Data.EntitiesConfig
{
    public class EnderecoConfig : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
        }
    }
}
