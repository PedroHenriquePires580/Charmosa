using CharmosaAPP.Domain.Entities;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CharmosaApp.Infra.Data.EntityConfig;
using CharmosaAPP.Domain.Entities.Base;

namespace CharmosaApp.Infra.Data.Contexto
{
    public class CharmosaAppContext : DbContext
    {
        public CharmosaAppContext(DbContextOptions<CharmosaAppContext> options) : base(options)
        {

        }
        #region | DbSets |
        DbSet<Administrador> Administrador { get; set; }
        DbSet<Carrinho> Carrinho { get; set; }
        DbSet<Cliente> Cliente { get; set; }
        DbSet<Funcionario> Funcionario { get; set; }
        DbSet<Produto> Produto { get; set; }
        DbSet<Roupa> Roupa { get; set; }
        DbSet<Telefone> Telefone { get; set; }
        DbSet<Usuario> Usuario { get; set; }

        #endregion



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region | Aplicando Configuration |

            /// <summary>
            /// Adicionando as referencias de configuração do EntityConfig
            /// </summary>
            modelBuilder.ApplyConfiguration(new AdministradorConfiguration());
            modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());
            modelBuilder.ApplyConfiguration(new RoupaConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new TelefoneConfiguration());
            modelBuilder.ApplyConfiguration(new CarrinhoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            
            #endregion
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CharmosaApp;Integrated Security=True;");
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
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now.Date;
                    entry.Property("RegistroAtivo").CurrentValue = 1;
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
