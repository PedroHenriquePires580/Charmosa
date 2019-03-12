using CharmosaApp.Application.Interfaces;
using CharmosaAPP.Domain.Entities;
using CharmosaAPP.Domain.Interfaces;


namespace CharmosaApp.Application
{
    public class AdministradorAppService : AppServiceBase<Administrador>,IAdministradorAppService
    {
        private  readonly IAdministradorRepository _repository;

        public AdministradorAppService(IRepositoryBase<Administrador> repositoryBase)
            :base(repositoryBase)
        {
            _repository = repositoryBase as IAdministradorRepository;
        }

    }
}
