using CharmosaAPP.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaAPP.Domain.Entities
{
    public class Carrinho : ClasseBase
    {
        public int CarrinhoID { get; set; }
        public int ClienteID { get; set; }
        public int ProdutoID { get; set; }
        public int Quantidade { get; set; }

        private double subTotal;
        public double SubTotal {
            get
            {
                return subTotal;
            }
            set
            {
                SubTotal = Quantidade * Mercadoria.ValorUnidade;
            }
        }
 
        public virtual Mercadoria Mercadoria { get; set; }
        public virtual Cliente Cliente { get; set; }

    }
}
