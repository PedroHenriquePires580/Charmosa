using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaAPP.Domain.Entities.Enumeradores
{
    public enum TamanhoRoupa
    {
        [Description("Extra-Pequena")]
        ExtraPequeno = 1,
        Pequeno = 2,
        [Description("Médio")]
        Medio = 3,
        Grande = 4,
        [Description("Extra-Grande")]
        ExtraGrande = 5
    }
}
