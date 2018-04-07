using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sifiscon.Domain.Entities;

namespace Sifiscon.Infra.Data.EntitiesConfig
{
    public class AutoDeInfracaoConfig : IEntityTypeConfiguration<AutoDeInfracao>
    {
        public void Configure(EntityTypeBuilder<AutoDeInfracao> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.GravidadeInfracao)
                .IsRequired();

            builder.Property(x => x.Atenuante)
                .IsRequired();

            builder.Property(x => x.Agravante)
                .IsRequired();

            //builder
            //    .HasOne(x => x.Processo)
            //    .WithMany(x => x.AutosDeInfracao);
        }
    }
}
