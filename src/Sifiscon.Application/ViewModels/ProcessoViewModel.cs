using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sifiscon.Application.ViewModels
{
    public class ProcessoViewModel : BaseViewModel
    {
        [Required]
        [MinLength(14)]
        [MaxLength(14)]
        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }

        [Required]
        [MaxLength(30)]
        [DisplayName("Número do Processo")]
        public string NumeroProcesso { get; set; }

        [Required]
        [MaxLength(1000)]
        [DisplayName("Relato da Fiscalização")]
        public string RelatoFiscalizacao { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        [DisplayName("Data do Relato")]
        public DateTime DataRelato { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("Fiscal Responsavel")]
        public string FiscalResposavel { get; set; }

        public ICollection<AutoDeInfracaoViewModel> AutosDeInfracao { get; set; }

        public FornecedorViewModel Fornecedor { get; set; }
    }
}
