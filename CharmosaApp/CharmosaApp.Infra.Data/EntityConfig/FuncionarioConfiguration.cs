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
            builder.HasKey(f => f.FuncionarioID);

            builder.Property(f => f.Nome)
                .IsRequired()
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(f => f.Sobrenome)
                .IsRequired()
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(f => f.Salario)
                .IsRequired();

            builder.ToTable("TB_FUNCIONARIO");

            builder.Property(f => f.LogInInclusao)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            builder.Property(f => f.LogInAlteracao)
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");


            builder.Property(f => f.UsuarioFuncao)
                .IsRequired();

            builder.Property(f => f.Login)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            builder.Property(f => f.Senha)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnType("nvarchar(30)"); 
        }
    }
}
