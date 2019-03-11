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
        public int MercadoriaID { get; set; }
        public TipoProduto TipoProduto { get; set; }
        public double ValorUnidade { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int QuantidadeReservada { get; set; }

        public virtual List<Cliente> Clientes { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
