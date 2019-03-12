using CharmosaApp.Application.Interfaces;
using CharmosaAPP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaApp.Application
{
    public class AppServiceBase<TEntity> : IDisposable,IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repositoryBase;

        public AppServiceBase(IRepositoryBase<TEntity> repository)
        {
            repositoryBase = repository;
        }

        public void Add(TEntity obj)
        {
            repositoryBase.Add(obj);
        }

        public void Dispose()
        {
            repositoryBase.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repositoryBase.GetAll();
        }

        public TEntity GetByID(int ID)
        {
            return repositoryBase.GetByID(ID);
        }

        public void Remove(TEntity obj)
        {
            repositoryBase.Remove(obj);
        }

        public IEnumerable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate)
        {
            return repositoryBase.SearchFor(predicate);
        }

        public void Update(TEntity obj)
        {
            repositoryBase.Update(obj);
        }
    }
}
