﻿using CharmosaApp.Infra.Data.Contexto;
using CharmosaAPP.Domain.Entities;
using CharmosaAPP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaApp.Infra.Data.Repositories
{
    public class RoupaRepository : RepositoryBase<Roupa>, IRoupaRepository
    {
        public RoupaRepository(CharmosaAppContext dbContext) : base(dbContext)
        {
        }
    }
}