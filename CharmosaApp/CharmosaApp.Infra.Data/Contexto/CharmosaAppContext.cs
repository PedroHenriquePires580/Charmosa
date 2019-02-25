using CharmosaAPP.Domain.Entities;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using CharmosaApp.Infra.Data.EntityConfig;

namespace CharmosaApp.Infra.Data.Contexto
{
    public class CharmosaAppContext : DbContext
    {
        public CharmosaAppContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CharmosaApp;Integrated Security=True;Connect Timeout=30;")
        {

        }

        DbSet<Administrador> Administrador { get; set; }
        DbSet<Funcionario> Funcionario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /// <summary>
            /// Configura as propriedades que tenham ID no final
            /// como chave primaria.
            /// </summary>
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "ID")
                .Configure(p => p.IsKey());

            /// <summary>
            /// Configura as propriedades setadas como string para
            /// varchar e tamanho máximo de 250
            /// </summary>
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(250));

            /// <summary>
            /// Configurando Login como obrigatório e tamanho máximo de 50  e senha 
            /// com tamanho máximo de 30
            /// </summary>
            modelBuilder.Properties()
                .Where(x => x.Name == "Login")
                .Configure(
                    x => x.IsRequired().HasMaxLength(50)
                );
            modelBuilder.Properties()
                .Where(x => x.Name == "Senha")
                .Configure(
                    x => x.IsRequired().HasMaxLength(30)
                );

            /// <summary>
            /// Adicionando as referencias de configuração do EntityConfig
            /// </summary>
            modelBuilder.Configurations.Add(new AdministradorConfiguration());
            modelBuilder.Configurations.Add(new FuncionarioConfiguration());
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
