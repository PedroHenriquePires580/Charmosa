using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaAPP.Domain.Interfaces
{
    public interface IUnitOfWork<T> : IDisposable  where T: class
    {
        IRepositoryBase<T> RepositoryBase { get; }
        IAdministradorRepository AdministradorRepository { get; }
        ICarrinhoRepository CarrinhoRepository { get; }
        IClienteRepository ClienteRepository { get; }
        IFuncionarioRepository FuncionarioRepository { get; }
        IProdutoRepository ProdutoRepository { get; }
        IRoupaRepository RoupaRepository { get; }
        ITelefoneRepository TelefoneRepository { get; }
        IUsuarioRepository UsuarioRepository { get; }
        void Commit();
    }
}
