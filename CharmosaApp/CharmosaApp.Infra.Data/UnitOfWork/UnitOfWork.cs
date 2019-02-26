using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharmosaApp.Infra.Data.Contexto;
using CharmosaApp.Infra.Data.Repositories;

namespace CharmosaApp.Infra.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private CharmosaAppContext dbContext;
        private FuncionarioRepository funcionarioRepository;
        private AdministradorRepository administradorRepository;

        public UnitOfWork(CharmosaAppContext context)
        {
            this.dbContext = context;
        }

        /// <summary>
        /// Instanciando os repositorios
        /// </summary>
       public FuncionarioRepository FuncionarioRepository
        {
            get
            {
                return this.funcionarioRepository ?? new FuncionarioRepository(this.dbContext);
            }   
        }
        public AdministradorRepository AdministradorRepository
        {
            get
            {
                return this.administradorRepository ?? new AdministradorRepository(this.dbContext);
            }
        }

        public void Commit()
        {
            dbContext.SaveChanges();
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
