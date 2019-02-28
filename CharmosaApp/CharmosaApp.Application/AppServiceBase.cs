using CharmosaApp.Application.Interfaces;
using CharmosaApp.Infra.Data.Contexto;
using CharmosaApp.Infra.Data.UnitOfWork;
using CharmosaAPP.Domain.Interfaces;
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
        private readonly IUnitOfWork<TEntity> _unitOfWork;

        public AppServiceBase(CharmosaAppContext dbContext)
        {
            _unitOfWork = new UnitOfWork<TEntity>(dbContext);
        }

    }
}
