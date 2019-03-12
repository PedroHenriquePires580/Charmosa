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
    public class CarrinhoConfiguration : IEntityTypeConfiguration<Carrinho>
    {
        public void Configure(EntityTypeBuilder<Carrinho> builder)
        {
            #region | Dados Compartilhados |
            builder.Property(c => c.LogInInclusao)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            builder.Property(c => c.LogInAlteracao)
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            #endregion
            #region | Dados Especificos |

            builder.HasKey(p => p.CarrinhoID);
            builder.ToTable("TB_CARRINHO");


            builder.Property(p => p.Quantidade)
                .IsRequired();
            builder.Property(p => p.SubTotal)
                .IsRequired();

            builder.HasOne(p => p.Usuario);
            builder.HasOne(p => p.Produto);

            builder.Property(p => p.UsuarioID)
                .IsRequired();
            builder.Property(p => p.ProdutoID)
                .IsRequired();

            #endregion
        }
    }
}
