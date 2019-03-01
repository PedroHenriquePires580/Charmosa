using CharmosaAPP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CharmosaApp.Infra.Data.EntityConfig
{
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        /// <summary>
        /// Configuração da classe Funcionario
        /// </summary>
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {


            #region | Dados Compartilhados |

            builder.Property(f => f.Nome)
                .IsRequired()
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(f => f.Sobrenome)
                .IsRequired()
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(f => f.Logradouro)
                .IsRequired()
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(f => f.Complemento)
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(f => f.CEP)
                .IsRequired()
                .HasColumnType("nvarchar(8)")
                .HasMaxLength(8);

            builder.Property(f => f.Bairro)
                .IsRequired()
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(f => f.UF)
                .IsRequired()
                .HasColumnType("nvarchar(2)")
                .HasMaxLength(2);

            builder.Property(f => f.CPF)
               .IsRequired()
               .HasColumnType("nvarchar(11)")
               .HasMaxLength(11);

            builder.Property(f => f.RG)
               .IsRequired()
               .HasColumnType("nvarchar(9)")
               .HasMaxLength(9);

            builder.Property(f => f.Numero)
               .IsRequired();

            builder.Property(f => f.DataNascimento)
               .IsRequired();

            builder.Property(f => f.UsuarioFuncao)
                .IsRequired();

            builder.Property(f => f.Email)
                .IsRequired()
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(f => f.LogInInclusao)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            builder.Property(f => f.LogInAlteracao)
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            builder.Property(f => f.Login)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            builder.Property(f => f.Senha)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnType("nvarchar(30)");
            #endregion

            #region | Propriedades Especificas |

            builder.ToTable("TB_FUNCIONARIO");

            builder.HasKey(f => f.FuncionarioID);
            builder.Property(f => f.Salario)
                .IsRequired();
            #endregion

        }
    }
}
