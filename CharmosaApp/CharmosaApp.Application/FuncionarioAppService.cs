using CharmosaApp.Application.Interfaces;
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
        public readonly IFuncionarioRepository funcionarioRepository;

        public FuncionarioAppService(IRepositoryBase<Funcionario> repositoryBase)
            :base(repositoryBase)
        {
            funcionarioRepository = repositoryBase as IFuncionarioRepository;
        }
    }
}
