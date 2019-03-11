using CharmosaAPP.Domain.Entities.Base;
using CharmosaAPP.Domain.Entities.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaAPP.Domain.Entities
{
    public class Roupa : ClasseBase
    {
        public int RoupaID { get; set; }
        public string Descricao { get; set; }
        public TamanhoRoupa TamanhoRoupa { get; set; }
        public TipoRoupa TipoRoupa { get; set; }
        public TipoProduto TipoProduto { get; set; }

    }
}
