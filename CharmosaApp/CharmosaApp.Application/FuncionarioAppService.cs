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
    public class FuncionarioAppService : AppServiceBase<Funcionario>, IFuncionarioAppService
    {
        public readonly IUnitOfWork<Funcionario> _funcionarioUnitOfWork;

        public FuncionarioAppService(CharmosaAppContext dbContext)
            :base(dbContext)
        {
            _funcionarioUnitOfWork = new UnitOfWork<Funcionario>(dbContext);
        }
    }
}
