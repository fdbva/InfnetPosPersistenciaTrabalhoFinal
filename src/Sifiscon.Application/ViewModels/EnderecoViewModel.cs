using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sifiscon.Domain.Constants;

namespace Sifiscon.Application.ViewModels
{
    public class EnderecoViewModel : BaseViewModel
    {
        [Required]
        [MaxLength(100)]
        public string Logradouro { get; set; }

        [Required]
        [MaxLength(50)]
        public string Numero { get; set; }

        [MaxLength(50)]
        public string Complemento { get; set; }

        [Required]
        [MaxLength(100)]
        public string Bairro { get; set; }

        [Required]
        [MaxLength(8)]
        [DisplayName("CEP")]
        public string Cep { get; set; }

        [Required]
        [MaxLength(200)]
        [DisplayName("Município")]
        public string Municipio { get; set; }

        [Required]
        public EnumUf UnidadeFederativa { get; set; }

        public FornecedorViewModel Fornecedor { get; set; }
    }
}
