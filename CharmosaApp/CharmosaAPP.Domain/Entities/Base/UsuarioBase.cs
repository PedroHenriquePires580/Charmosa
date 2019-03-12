using CharmosaAPP.Domain.Entities.Base;
using CharmosaAPP.Domain.Entities.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaAPP.Domain.Entities
{
    public abstract class UsuarioBase : ClasseBase
    {
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        string GetFuncaoDescricao(int ID)
        {
            return Enum.GetNames(typeof(UsuarioFuncao)).GetValue(ID).ToString();
        }
    }
}
