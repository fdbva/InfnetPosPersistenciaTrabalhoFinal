using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sifiscon.Application.ViewModels
{
    public class ProdutoViewModel : BaseViewModel
    {
        [Required]
        [MaxLength(200)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(200)]
        public string Marca { get; set; }

        [Required]
        [MaxLength(200)]
        public string Estoque { get; set; }
    }
}
