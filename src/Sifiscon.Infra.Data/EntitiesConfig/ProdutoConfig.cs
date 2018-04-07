using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sifiscon.Domain.Entities;

namespace Sifiscon.Infra.Data.EntitiesConfig
{
    public class ProdutoConfig : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Marca)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Estoque)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
