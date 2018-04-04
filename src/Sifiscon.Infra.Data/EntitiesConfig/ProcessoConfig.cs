using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sifiscon.Domain.Entities;

namespace Sifiscon.Infra.Data.EntitiesConfig
{
    public class ProcessoConfig : IEntityTypeConfiguration<Processo>
    {
        public void Configure(EntityTypeBuilder<Processo> builder)
        {
        }
    }
}
