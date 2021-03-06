﻿using CharmosaApp.Infra.Data.Contexto;
using CharmosaAPP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaApp.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected CharmosaAppContext dbContext;

        public RepositoryBase(CharmosaAppContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Add(TEntity obj)
        {
            dbContext.Set<TEntity>().Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbContext.Set<TEntity>().ToList();
        }

        public TEntity GetByID(int ID)
        {
             return dbContext.Set<TEntity>().Find(ID);
        }

        public void Remove(TEntity obj)
        {
            dbContext.Set<TEntity>().Remove(obj);
        }

        public void Update(TEntity obj)
        {
            dbContext.Set<TEntity>().Update(obj);
            //dbContext.Entry(obj).State = EntityState.Modified;
        }
        public void Dispose()
        {
            dbContext.Dispose();
        }

        public IEnumerable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate)
        {
            return dbContext.Set<TEntity>()
                .Where(predicate)
                ?.ToList();
        }
    }
}
