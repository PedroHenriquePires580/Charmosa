using System;
using System.Collections.Generic;
using System.Linq.Expressions;


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
