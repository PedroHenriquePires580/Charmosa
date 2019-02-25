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
    public class FuncionarioService : ServiceBase<Funcionario>,IFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioService(IFuncionarioRepository funcionarioRepository)
            :base(funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }
    }
}
