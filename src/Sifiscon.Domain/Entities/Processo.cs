using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sifiscon.Domain.Entities
{
    public class Processo : BaseEntity
    {
        //será que precisa do Cnpj? Ou propriedade de navegação para o Fornecedor? Uma empresa pode trocar de Cnpj e teria que ficar registrado o antigo?
        public string Cnpj { get; set; }
        public string RelatoFiscalizacao { get; set; }
        public DateTime DataRelato { get; set; }
        public string FiscalResposavel { get; set; }
        public ICollection<AutoDeInfracao> AutosDeInfracao { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
