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
        IFuncionarioRepository FuncionarioRepository { get; }
        IRoupaRepository RoupaRepository { get; }
        void Commit();
    }
}
