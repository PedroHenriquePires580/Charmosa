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
    public class FuncionarioAppService : AppServiceBase<Funcionario>, IFuncionarioAppService
    {
        private readonly IFuncionarioService _funcionarioService;

        public FuncionarioAppService(IFuncionarioService funcionarioService)
            :base(funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }
    }
}
