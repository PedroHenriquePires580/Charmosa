using CharmosaAPP.Domain.Entities;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CharmosaApp.Infra.Data.EntityConfig;

namespace CharmosaApp.Infra.Data.Contexto
{
    public class CharmosaAppContext : DbContext
    {
        public CharmosaAppContext(DbContextOptions<CharmosaAppContext> options) : base(options)
        {

        }

        DbSet<Administrador> Administrador { get; set; }
        DbSet<Funcionario> Funcionario { get; set; }

        DbSet<Roupa> Roupa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /// <summary>
            /// Adicionando as referencias de configuração do EntityConfig
            /// </summary>
            modelBuilder.ApplyConfiguration(new AdministradorConfiguration());
            modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());
            modelBuilder.ApplyConfiguration(new RoupaConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("CharmosaCon");
        }


        /// <summary>
        /// Quando o método SaveChanges for ativado, coloca a data de inclusão do registro
        /// com a data atual e se o registro esta ativo no banco como 1
        /// </summary>
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries()
                .Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                    entry.Property("RegistroAtivo").CurrentValue = true;
                    entry.Property("LogInInclusao").CurrentValue = "ADMINISTRADOR";
                }
                if(entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
