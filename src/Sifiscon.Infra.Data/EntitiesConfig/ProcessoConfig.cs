using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sifiscon.Domain.Entities;

namespace Sifiscon.Infra.Data.EntitiesConfig
{
    public class ProcessoConfig : IEntityTypeConfiguration<Processo>
    {
        public void Configure(EntityTypeBuilder<Processo> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Cnpj)
                .HasMaxLength(14)
                .IsRequired();

            builder.Property(x => x.NumeroProcesso)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(x => x.RelatoFiscalizacao)
                .HasMaxLength(1000)
                .IsRequired();

            builder.Property(x => x.DataRelato)
                .IsRequired();

            builder.Property(x => x.FiscalResposavel)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .HasMany(x => x.AutosDeInfracao)
                .WithOne(x => x.Processo);

            //builder
            //    .HasOne(x => x.Fornecedor)
            //    .WithMany(x => x.Processos);
        }
    }
}
