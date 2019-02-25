using AutoMapper;
using CharmosaApp.MVC.ViewModels;
using CharmosaAPP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharmosaApp.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {

        public DomainToViewModelMappingProfile()
        {
            CreateMap<Administrador, AdministradorViewModel>();
            CreateMap<Funcionario, FuncionarioViewModel>();
        }
    }
}
