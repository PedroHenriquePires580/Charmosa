using CharmosaApp.Application.Interfaces;
using CharmosaApp.Infra.Data.Contexto;
using CharmosaApp.Infra.Data.UnitOfWork;
using CharmosaAPP.Domain.Entities;
using CharmosaAPP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaApp.Application
{
    public class CarrinhoAppService : AppServiceBase<Carrinho>, ICarrinhoAppService
    {
        public IUnitOfWork<Carrinho> unitOfWork;
        public CarrinhoAppService(CharmosaAppContext dbContext) : base(dbContext)
        {
            unitOfWork = new UnitOfWork<Carrinho>(dbContext);
        }
    }
}
