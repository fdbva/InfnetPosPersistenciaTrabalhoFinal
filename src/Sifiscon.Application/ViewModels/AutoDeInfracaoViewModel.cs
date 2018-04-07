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
    public class AutoDeInfracaoViewModel : BaseViewModel
    {
        [Required]
        [DisplayName("Gravidade da Infração")]
        public EnumGravidadeInfracao GravidadeInfracao { get; set; }

        [Required]
        public bool Atenuante { get; set; }

        [Required]
        public bool Agravante { get; set; }
    }
}
