﻿// <auto-generated />
using System;
using CharmosaApp.Infra.Data.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CharmosaApp.MVC.Migrations
{
    [DbContext(typeof(CharmosaAppContext))]
    partial class CharmosaAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CharmosaAPP.Domain.Entities.Administrador", b =>
                {
                    b.Property<int>("AdmistradorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Email");

                    b.Property<string>("LogInAlteracao")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LogInInclusao")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("RegistroAtivo");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("UsuarioFuncao");

                    b.HasKey("AdmistradorID");

                    b.ToTable("TB_ADMINISTRADOR");
                });

            modelBuilder.Entity("CharmosaAPP.Domain.Entities.Carrinho", b =>
                {
                    b.Property<int>("CarrinhoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteID");

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("LogInAlteracao");

                    b.Property<string>("LogInInclusao");

                    b.Property<int>("ProdutoID");

                    b.Property<int>("Quantidade");

                    b.Property<int>("RegistroAtivo");

                    b.Property<double>("SubTotal");

                    b.HasKey("CarrinhoID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("ProdutoID");

                    b.ToTable("Carrinho");
                });

            modelBuilder.Entity("CharmosaAPP.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("LogInAlteracao")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LogInInclusao")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("Numero");

                    b.Property<int?>("ProdutoID");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.Property<int>("RegistroAtivo");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<int>("UsuarioFuncao");

                    b.HasKey("ClienteID");

                    b.HasIndex("ProdutoID");

                    b.ToTable("TB_CLIENTE");
                });

            modelBuilder.Entity("CharmosaAPP.Domain.Entities.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("LogInAlteracao")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LogInInclusao")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("Numero");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.Property<int>("RegistroAtivo");

                    b.Property<double>("Salario");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<int>("UsuarioFuncao");

                    b.HasKey("FuncionarioID");

                    b.ToTable("TB_FUNCIONARIO");
                });

            modelBuilder.Entity("CharmosaAPP.Domain.Entities.Produto", b =>
                {
                    b.Property<int>("ProdutoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteID");

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("LogInAlteracao");

                    b.Property<string>("LogInInclusao");

                    b.Property<int>("MercadoriaID");

                    b.Property<int>("QuantidadeEstoque");

                    b.Property<int>("QuantidadeReservada");

                    b.Property<int>("RegistroAtivo");

                    b.Property<int>("TipoProduto");

                    b.Property<double>("ValorUnidade");

                    b.HasKey("ProdutoID");

                    b.HasIndex("ClienteID");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("CharmosaAPP.Domain.Entities.Roupa", b =>
                {
                    b.Property<int>("RoupaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar")
                        .HasMaxLength(250);

                    b.Property<string>("LogInAlteracao")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LogInInclusao")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("RegistroAtivo");

                    b.Property<int>("TamanhoRoupa");

                    b.Property<int>("TipoProduto");

                    b.Property<int>("TipoRoupa");

                    b.HasKey("RoupaID");

                    b.ToTable("TB_ROUPA");
                });

            modelBuilder.Entity("CharmosaAPP.Domain.Entities.Telefone", b =>
                {
                    b.Property<int>("TelefoneID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdministradorAdmistradorID");

                    b.Property<int>("ClienteID");

                    b.Property<string>("DDD")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 64)))
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<int?>("FuncionarioID");

                    b.Property<string>("LogInAlteracao")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LogInInclusao")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("RegistroAtivo");

                    b.HasKey("TelefoneID");

                    b.HasIndex("AdministradorAdmistradorID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("FuncionarioID");

                    b.ToTable("TB_TELEFONE");
                });

            modelBuilder.Entity("CharmosaAPP.Domain.Entities.Carrinho", b =>
                {
                    b.HasOne("CharmosaAPP.Domain.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharmosaAPP.Domain.Entities.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CharmosaAPP.Domain.Entities.Cliente", b =>
                {
                    b.HasOne("CharmosaAPP.Domain.Entities.Produto", "Produto")
                        .WithMany("Clientes")
                        .HasForeignKey("ProdutoID");
                });

            modelBuilder.Entity("CharmosaAPP.Domain.Entities.Produto", b =>
                {
                    b.HasOne("CharmosaAPP.Domain.Entities.Cliente", "Cliente")
                        .WithMany("Produtos")
                        .HasForeignKey("ClienteID");
                });

            modelBuilder.Entity("CharmosaAPP.Domain.Entities.Telefone", b =>
                {
                    b.HasOne("CharmosaAPP.Domain.Entities.Administrador")
                        .WithMany("Telefones")
                        .HasForeignKey("AdministradorAdmistradorID");

                    b.HasOne("CharmosaAPP.Domain.Entities.Cliente", "Cliente")
                        .WithMany("Telefones")
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharmosaAPP.Domain.Entities.Funcionario")
                        .WithMany("Telefones")
                        .HasForeignKey("FuncionarioID");
                });
#pragma warning restore 612, 618
        }
    }
}
