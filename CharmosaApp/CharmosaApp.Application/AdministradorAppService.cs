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
    public class AdministradorAppService : AppServiceBase<Administrador>,IAdministradorAppService
    {
        public  readonly IUnitOfWork<Administrador> _administradorUnitOfWork;

        public AdministradorAppService(CharmosaAppContext dbContext)
            :base(dbContext)
        {
            _administradorUnitOfWork = new UnitOfWork<Administrador>(dbContext);
        }
    }
}
