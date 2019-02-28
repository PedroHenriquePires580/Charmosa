﻿// <auto-generated />
using System;
using CharmosaApp.Infra.Data.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CharmosaApp.MVC.Migrations
{
    [DbContext(typeof(CharmosaAppContext))]
    [Migration("20190228121300_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("LogInAlteracao")
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 64)))
                        .HasColumnType("varchar")
                        .HasMaxLength(50);

                    b.Property<string>("LogInInclusao")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 64)))
                        .HasColumnType("varchar")
                        .HasMaxLength(50);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasMaxLength(50);

                    b.Property<bool>("RegistroAtivo");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasMaxLength(30);

                    b.Property<int>("UsuarioCodFuncao");

                    b.HasKey("AdmistradorID");

                    b.ToTable("TB_ADMINISTRADOR");
                });

            modelBuilder.Entity("CharmosaAPP.Domain.Entities.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("LogInAlteracao")
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 64)))
                        .HasColumnType("varchar")
                        .HasMaxLength(50);

                    b.Property<string>("LogInInclusao")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 64)))
                        .HasColumnType("varchar")
                        .HasMaxLength(50);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasMaxLength(50);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasMaxLength(250);

                    b.Property<bool>("RegistroAtivo");

                    b.Property<decimal>("Salario");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasMaxLength(30);

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasMaxLength(250);

                    b.Property<int>("UsuarioCodFuncao");

                    b.HasKey("FuncionarioID");

                    b.ToTable("TB_FUNCIONARIO");
                });
#pragma warning restore 612, 618
        }
    }
}