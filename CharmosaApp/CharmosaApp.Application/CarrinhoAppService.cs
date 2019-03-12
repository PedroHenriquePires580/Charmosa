using CharmosaApp.Application.Interfaces;
using CharmosaAPP.Domain.Entities;
using CharmosaAPP.Domain.Interfaces;

namespace CharmosaApp.Application
{
    public class CarrinhoAppService : AppServiceBase<Carrinho>, ICarrinhoAppService
    {
        private readonly ICarrinhoRepository _carrinhoRepository;
        public CarrinhoAppService(IRepositoryBase<Carrinho> repositoryBase) : base(repositoryBase)
        {
            _carrinhoRepository = repositoryBase as ICarrinhoRepository;
        }
    }
}
