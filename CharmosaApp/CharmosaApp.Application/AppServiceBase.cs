using CharmosaApp.Application.Interfaces;
using CharmosaAPP.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaApp.Application
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _appService;

        public AppServiceBase(IServiceBase<TEntity> appService)
        {
            _appService = appService;
        }

        public void Add(TEntity obj)
        {
            _appService.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _appService.GetAll();
        }

        public TEntity GetByID(int ID)
        {
            return _appService.GetByID(ID);
        }

        public void Remove(TEntity obj)
        {
            _appService.Remove(obj);
        }

        public IEnumerable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate)
        {
            return _appService.SearchFor(predicate);
        }

        public void Update(TEntity obj)
        {
            _appService.Update(obj);
        }

        public void Dispose()
        {
            _appService.Dispose();
        }
    }
}
