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
    public class UnitOfWork : IUnitOfWork
    {
        #region | Variaveis |
        private CharmosaAppContext dbContext;

        private IAdministradorRepository administradorRepository;
        private ICarrinhoRepository carrinhoRepository;
        private IClienteRepository clienteRepository;
        private IFuncionarioRepository funcionarioRepository;
        private IProdutoRepository produtoRepository;
        private IRoupaRepository roupaRepository;
        private ITelefoneRepository telefoneRepository;
        private IUsuarioRepository usuarioRepository;
        #endregion

        public UnitOfWork(CharmosaAppContext context)
        {
            this.dbContext = context;
        }

        /// <summary>
        /// Instanciando os repositorios
        /// </summary>
         
        public IAdministradorRepository AdministradorRepository
        {
            get
            {
                return this.administradorRepository ?? new AdministradorRepository(this.dbContext);
            }
        }
        public ICarrinhoRepository CarrinhoRepository
        {
            get
            {
                return this.carrinhoRepository ?? new CarrinhoRepository(this.dbContext);
            }
        }
        public IClienteRepository ClienteRepository
        {
            get
            {
                return this.clienteRepository ?? new ClienteRepository(this.dbContext);
            }
        }
        public IFuncionarioRepository FuncionarioRepository
        {
            get
            {
                return this.funcionarioRepository ?? new FuncionarioRepository(this.dbContext);
            }
        }

        public IProdutoRepository ProdutoRepository {
            get
            {
                return this.produtoRepository ?? new ProdutoRepository(this.dbContext);
            }
        }

        public IRoupaRepository RoupaRepository
        {
            get
            {
                return this.roupaRepository ?? new RoupaRepository(this.dbContext);
            }
        }
        public ITelefoneRepository TelefoneRepository
        {
            get
            {
                return this.telefoneRepository ?? new TelefoneRepository(this.dbContext);
            }
        }

        public IUsuarioRepository UsuarioRepository
        {
            get
            {
                return this.usuarioRepository ?? new UsuarioRepository(this.dbContext);
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
