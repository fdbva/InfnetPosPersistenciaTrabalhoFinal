using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sifiscon.Domain.Entities;

namespace Sifiscon.Infra.Data.EntitiesConfig
{
    public class EnderecoConfig : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Logradouro)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Numero)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Complemento)
                .HasMaxLength(50);

            builder.Property(x => x.Bairro)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Cep)
                .HasMaxLength(8)
                .IsRequired();

            builder.Property(x => x.Municipio)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.UnidadeFederativa)
                .IsRequired();

            //builder
            //    .HasOne(x => x.Fornecedor)
            //    .WithMany(x => x.Enderecos);
        }
    }
}
