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
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            #region | Dados Especificos |
            builder.ToTable("TB_PRODUTO");

            builder.HasKey(p => p.ProdutoID);

            builder.Property(p => p.QuantidadeEstoque)
                .IsRequired();
            builder.Property(p => p.QuantidadeReservada)
                .IsRequired();
            builder.Property(p => p.ValorUnidade)
                .IsRequired();

            builder.Property(p => p.TipoProduto)
                .IsRequired();
            builder.Property(m => m.MercadoriaID)
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
