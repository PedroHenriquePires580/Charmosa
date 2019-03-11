using CharmosaAPP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaApp.Infra.Data.EntityConfig
{
    public class RoupaConfiguration : IEntityTypeConfiguration<Roupa>
    {
        /// <summary>
        /// Configuração da classe Administrador
        /// </summary>
        public void Configure(EntityTypeBuilder<Roupa> builder)
        {
            #region | Dados Especificos |
            builder.HasKey(r => r.RoupaID);

            builder.ToTable("TB_ROUPA");

            builder.Property(r => r.Descricao)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnType("nvarchar");

            builder.Property(r => r.TamanhoRoupa)
                .IsRequired();

            builder.Property(r => r.TipoRoupa)
                .IsRequired();


            builder.Property(p => p.TipoProduto)
                .IsRequired();

            #endregion

            #region | Dados Compartilhados |
            builder.Property(c => c.LogInInclusao)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            builder.Property(c => c.LogInAlteracao)
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            #endregion


        }
    }
}
