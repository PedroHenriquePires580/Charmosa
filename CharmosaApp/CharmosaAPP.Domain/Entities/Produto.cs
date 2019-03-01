using CharmosaAPP.Domain.Entities.Base;
using CharmosaAPP.Domain.Entities.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaAPP.Domain.Entities
{
    public class Produto : ClasseBase
    {
        public int ProdutoID { get; set; }
        public TipoProduto TipoProduto { get; set; }

        public List<Cliente> Clientes { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Mercadoria Mercadoria { get; set; }
    }
}
