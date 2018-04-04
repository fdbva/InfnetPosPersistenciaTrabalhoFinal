using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sifiscon.Domain.Entities
{
    public class Fornecedor : BaseEntity
    {
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string InscricaoMunicipal { get; set; }
        public decimal ReceitaBruta { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
        public ICollection<Processo> Processos { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
