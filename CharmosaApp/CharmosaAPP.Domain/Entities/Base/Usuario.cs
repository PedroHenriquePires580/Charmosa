using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaAPP.Domain.Entities
{
    public abstract class Usuario
    {
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
