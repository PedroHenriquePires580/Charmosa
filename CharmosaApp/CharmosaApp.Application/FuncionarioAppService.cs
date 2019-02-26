using CharmosaApp.Application.Interfaces;
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
    public class FuncionarioAppService : AppServiceBase<Funcionario>, IFuncionarioAppService
    {
        public readonly UnitOfWork<Funcionario> _funcionarioUnitOfWork;

        public FuncionarioAppService(UnitOfWork<Funcionario> funcionarioUnitOfWork)
            :base(funcionarioUnitOfWork)
        {
            _funcionarioUnitOfWork = funcionarioUnitOfWork;
        }
    }
}
