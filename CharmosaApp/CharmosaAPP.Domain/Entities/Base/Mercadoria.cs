using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaAPP.Domain.Entities.Base
{
    public abstract class Mercadoria : ClasseBase
    {
        public decimal ValorUnidade { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int QuantidadeReservada { get; set; }
    }
}
