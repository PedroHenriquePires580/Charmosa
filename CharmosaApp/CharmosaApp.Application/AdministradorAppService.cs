using CharmosaApp.Application.Interfaces;
using CharmosaAPP.Domain.Entities;
using CharmosaAPP.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaApp.Application
{
    public class AdministradorAppService : AppServiceBase<Administrador>,IAdministradorAppService
    {
        private  readonly IAdministradorService _administradorService;

        public AdministradorAppService(IAdministradorService administradorService)
            :base(administradorService)
        {
            _administradorService = administradorService;
        }
    }
}
