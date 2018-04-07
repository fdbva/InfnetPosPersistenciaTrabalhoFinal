using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sifiscon.Domain.Entities;

namespace Sifiscon.Infra.Data.EntitiesConfig
{
    public class FornecedorConfig : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Cnpj)
                .HasMaxLength(14)
                .IsRequired();

            builder.Property(x => x.RazaoSocial)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.InscricaoMunicipal)
                .HasMaxLength(8)
                .IsRequired();

            builder.Property(x => x.ReceitaBruta)
                .IsRequired();

            builder
                .HasMany(x => x.Enderecos)
                .WithOne(x => x.Fornecedor);

            builder
                .HasMany(x => x.Processos)
                .WithOne(x => x.Fornecedor);

            builder
                .HasMany(x => x.Produtos)
                .WithOne(x => x.Fornecedor);
        }
    }
}
