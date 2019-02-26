using CharmosaApp.Infra.Data.Contexto;
using CharmosaAPP.Domain.Entities;
using CharmosaAPP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaApp.Infra.Data.Repositories
{
    public class FuncionarioRepository : RepositoryBase<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(CharmosaAppContext dbContext)
            :base(dbContext)
        {
            
        }

    }
}
