using CharmosaAPP.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaAPP.Domain.Entities
{
    public class Telefone : ClasseBase
    {
        public int TelefoneID { get; set; }
        public int ClienteID { get; set; }
        public int DDD { get; set; }
        public string Numero { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
