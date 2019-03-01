using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharmosaApp.Infra.Data.Contexto;
using CharmosaApp.Infra.Data.Repositories;
using CharmosaAPP.Domain.Interfaces;

namespace CharmosaApp.Infra.Data.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private CharmosaAppContext dbContext;
        private IFuncionarioRepository funcionarioRepository;
        private IAdministradorRepository administradorRepository;
        private IClienteRepository clienteRepository;
        private ITelefoneRepository telefoneRepository;
        private IRepositoryBase<T> repositoryBase;
        private IRoupaRepository roupaRepository;
        public UnitOfWork(CharmosaAppContext context)
        {
            this.dbContext = context;
        }

        /// <summary>
        /// Instanciando os repositorios
        /// </summary>
        public IFuncionarioRepository FuncionarioRepository
        {
            get
            {
                return this.funcionarioRepository ?? new FuncionarioRepository(this.dbContext);
            }
        }
        public IClienteRepository ClienteRepository
        {
            get
            {
                return this.clienteRepository ?? new ClienteRepository(this.dbContext);
            }
        }
        public ITelefoneRepository TelefoneRepository
        {
            get
            {
                return this.telefoneRepository ?? new TelefoneRepository(this.dbContext);
            }
        }
        public IAdministradorRepository AdministradorRepository
        {
            get
            {
                return this.administradorRepository ?? new AdministradorRepository(this.dbContext);
            }
        }
        public IRepositoryBase<T> RepositoryBase
        {
            get
            {
                return this.repositoryBase ?? new RepositoryBase<T>(this.dbContext);
            }
        }
        public IRoupaRepository RoupaRepository
        {
            get
            {
                return this.roupaRepository ?? new RoupaRepository(this.dbContext);
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
