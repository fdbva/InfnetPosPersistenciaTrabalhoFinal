using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sifiscon.Domain.Entities
{
    public class Produto : BaseEntity
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Estoque { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
