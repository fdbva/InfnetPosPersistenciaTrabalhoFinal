using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sifiscon.Domain.Entities;

namespace Sifiscon.Infra.Data.EntitiesConfig
{
    public class FornecedorConfig : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
        }
    }
}
