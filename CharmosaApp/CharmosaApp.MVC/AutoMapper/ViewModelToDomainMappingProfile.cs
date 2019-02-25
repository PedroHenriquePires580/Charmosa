using AutoMapper;
using CharmosaApp.MVC.ViewModels;
using CharmosaAPP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharmosaApp.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappingProfile"; }
        }

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AdministradorViewModel, Administrador>();
            CreateMap<FuncionarioViewModel, Funcionario>();
        }
    }
}
