using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sifiscon.Domain.Entities;

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
        }

        public DbSet<AutoDeInfracao> AutosDeInfracao { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Processo> Processos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
