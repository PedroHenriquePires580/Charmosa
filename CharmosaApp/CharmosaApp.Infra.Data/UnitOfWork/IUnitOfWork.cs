using CharmosaApp.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaApp.Infra.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable 
    {
        void Commit();
    }
}
