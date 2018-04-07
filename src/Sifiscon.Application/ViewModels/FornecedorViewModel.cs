using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sifiscon.Application.ViewModels
{
    public class FornecedorViewModel : BaseViewModel
    {
        [Required]
        [MaxLength(14)]
        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }

        [Required]
        [MaxLength(200)]
        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }

        [Required]
        [MaxLength(8)]
        [DisplayName("Inscrição Municipal")]
        public string InscricaoMunicipal { get; set; }

        [Required]
        [DisplayName("DatReceita Bruta")]
        public decimal ReceitaBruta { get; set; }

        public ICollection<EnderecoViewModel> Enderecos { get; set; }

        public ICollection<ProcessoViewModel> Processos { get; set; }

        public ICollection<ProdutoViewModel> Produtos { get; set; }
    }
}
