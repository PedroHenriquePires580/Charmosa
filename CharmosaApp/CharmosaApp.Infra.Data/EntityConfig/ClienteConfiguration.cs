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
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            #region | Dados Compartilhados |

            builder.HasMany(c => c.Produtos)
                .WithOne(c => c.Cliente);
                

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(c => c.Sobrenome)
                .IsRequired()
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(c => c.Logradouro)
                .IsRequired()
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(c => c.Complemento)
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(c => c.CEP)
                .IsRequired()
                .HasColumnType("nvarchar(8)")
                .HasMaxLength(8);

            builder.Property(c => c.Bairro)
                .IsRequired()
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(c => c.UF)
                .IsRequired()
                .HasColumnType("nvarchar(2)")
                .HasMaxLength(2);

            builder.Property(c => c.CPF)
               .IsRequired()
               .HasColumnType("nvarchar(11)")
               .HasMaxLength(11);

            builder.Property(c => c.RG)
               .IsRequired()
               .HasColumnType("nvarchar(9)")
               .HasMaxLength(9);

            builder.Property(c => c.Numero)
               .IsRequired();

            builder.Property(c => c.DataNascimento)
               .IsRequired();

            builder.Property(c => c.UsuarioFuncao)
                .IsRequired();

            builder.Property(c => c.Email)
                .IsRequired()
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(c => c.LogInInclusao)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            builder.Property(c => c.LogInAlteracao)
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            builder.Property(c => c.Login)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            builder.Property(c => c.Senha)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnType("nvarchar(30)");

            #endregion

            #region | Dados Especificos |
            builder.Property(c => c.ClienteID)
                .IsRequired();

            builder.ToTable("TB_CLIENTE")
                .HasMany(c => c.Telefones)
                .WithOne(t => t.Cliente);

            #endregion
        }
    }
}
