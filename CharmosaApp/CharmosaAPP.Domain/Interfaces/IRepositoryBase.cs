using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaAPP.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Remove(TEntity obj);
        void Update(TEntity obj);
        void Dispose();
        IEnumerable<TEntity> GetAll();
        TEntity GetByID(int ID);
        IEnumerable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate);
        

    }
}
