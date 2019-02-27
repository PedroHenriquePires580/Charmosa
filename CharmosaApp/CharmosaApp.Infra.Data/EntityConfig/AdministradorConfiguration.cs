using CharmosaAPP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CharmosaApp.Infra.Data.EntityConfig
{
    public class AdministradorConfiguration : IEntityTypeConfiguration<Administrador>
    {
        /// <summary>
        /// Configuração da classe Administrador
        /// </summary>
        public void Configure(EntityTypeBuilder<Administrador> builder)
        {
            builder.HasKey(a => a.AdmistradorID);
            builder.ToTable("TB_ADMINISTRADOR");

            builder.Property(a => a.LogInInclusao)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            builder.Property(a => a.LogInAlteracao)
                .HasMaxLength(50)
                .HasColumnType("varchar");


            builder.Property(a => a.UsuarioCodFuncao)
                .IsRequired();

            builder.Property(a => a.Login)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            builder.Property(a => a.Senha)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnType("varchar");
        }
    }
}
