﻿using CharmosaAPP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaApp.Infra.Data.EntityConfig
{
    public class FuncionarioConfiguration : EntityTypeConfiguration<Funcionario>
    {
        /// <summary>
        /// Configuração da classe Funcionario
        /// </summary>
        public FuncionarioConfiguration()
        {
            HasKey(f => f.FuncionarioID);

            ToTable("TB_FUNCIONARIO");
        }
    }
}
