using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sifiscon.Domain.Entities
{
    public class Processo : BaseEntity
    {
        //será que precisa? Ou propriedade de navegação para o Fornecedor?
        public string Cnpj { get; set; }
        public string RelatoFiscalizacao { get; set; }
        public DateTime DataRelato { get; set; }
        public string FiscalResposavel { get; set; }
        public ICollection<AutoDeInfracao> AutosDeInfracao { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
