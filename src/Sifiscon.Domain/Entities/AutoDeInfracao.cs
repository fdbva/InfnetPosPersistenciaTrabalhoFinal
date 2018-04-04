using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sifiscon.Domain.Interfaces.Constants;

namespace Sifiscon.Domain.Entities
{
    public class AutoDeInfracao : BaseEntity
    {
        public EnumGravidadeInfracao GravidadeInfracao { get; set; }
        public bool Atenuante { get; set; }
        public bool Agravante { get; set; }
        public Processo Processo { get; set; }
    }
}
