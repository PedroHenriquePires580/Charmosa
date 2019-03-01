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
    public class TelefoneConfiguration : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            #region | Dados Especificos |
            builder.Property(t => t.TelefoneID)
                .IsRequired();

            builder.Property(t => t.DDD)
                .IsRequired()
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Numero)
                .IsRequired()
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);
            #endregion
            #region | Dados Compartilhados |
            #endregion
        }
    }
}
