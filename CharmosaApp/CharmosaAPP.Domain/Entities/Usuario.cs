using CharmosaAPP.Domain.Entities.Base;
using CharmosaAPP.Domain.Entities.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaAPP.Domain.Entities
{
    public class Usuario : ClasseBase
    {
        public int UsuarioBaseID { get; set; }
        public int UsuarioID { get; set; }
        public UsuarioFuncao UsuarioFuncao { get; set; }
    }
}
