using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sifiscon.Domain.Entities;

namespace Sifiscon.Infra.Data.EntitiesConfig
{
    public class AutoDeInfracaoConfig : IEntityTypeConfiguration<AutoDeInfracao>
    {
        public void Configure(EntityTypeBuilder<AutoDeInfracao> builder)
        {
        }
    }
}
