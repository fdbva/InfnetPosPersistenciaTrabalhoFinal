using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sifiscon.Domain.Entities;
using Sifiscon.Infra.Data.EntitiesConfig;

namespace Sifiscon.Infra.Data.Context
{
    public class SifisconContext : DbContext
    {
        public SifisconContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AutoDeInfracaoConfig());
            modelBuilder.ApplyConfiguration(new EnderecoConfig());
            modelBuilder.ApplyConfiguration(new FornecedorConfig());
            modelBuilder.ApplyConfiguration(new ProcessoConfig());
            modelBuilder.ApplyConfiguration(new ProcessoConfig());
        }

        public DbSet<AutoDeInfracao> AutosDeInfracao { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Processo> Processos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
