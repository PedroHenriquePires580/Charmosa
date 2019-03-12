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
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            #region | Metodos Especificos |
            builder.ToTable("TB_USUARIO");
            builder.HasKey(u => u.UsuarioBaseID);

            builder.Property(u => u.UsuarioID)
                .IsRequired();

            builder.Property(u => u.UsuarioFuncao)
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
