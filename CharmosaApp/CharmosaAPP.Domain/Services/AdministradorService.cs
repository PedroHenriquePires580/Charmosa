using CharmosaAPP.Domain.Entities;
using CharmosaAPP.Domain.Interfaces;
using CharmosaAPP.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaAPP.Domain.Services
{
    public class AdministradorService : ServiceBase<Administrador>, IAdministradorService
    {
        private readonly IAdministradorRepository _administradorRepository;
        public AdministradorService(IAdministradorRepository administradorRepository) 
            : base(administradorRepository)
        {
            _administradorRepository = administradorRepository;
        }
    }
}
