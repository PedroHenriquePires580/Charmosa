using CharmosaAPP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaApp.Infra.Data.EntityConfig
{
    public class AdministradorConfiguration : EntityTypeConfiguration<Administrador>
    {
        /// <summary>
        /// Configuração da classe Administrador
        /// </summary>
        public AdministradorConfiguration()
        {
            HasKey(a => a.AdmistradorID);

            ToTable("TB_ADMINISTRADOR");
        }
    }
}
