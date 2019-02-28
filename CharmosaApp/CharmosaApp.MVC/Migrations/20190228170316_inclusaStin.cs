using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CharmosaApp.MVC.Migrations
{
    public partial class inclusaStin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ADMINISTRADOR",
                columns: table => new
                {
                    AdmistradorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    LogInInclusao = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    LogInAlteracao = table.Column<string>(type: "varchar", maxLength: 50, nullable: true),
                    RegistroAtivo = table.Column<bool>(nullable: false),
                    UsuarioCodFuncao = table.Column<int>(nullable: false),
                    Login = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    Senha = table.Column<string>(type: "varchar", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ADMINISTRADOR", x => x.AdmistradorID);
                });

            migrationBuilder.CreateTable(
                name: "TB_FUNCIONARIO",
                columns: table => new
                {
                    FuncionarioID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    LogInInclusao = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    LogInAlteracao = table.Column<string>(type: "varchar", maxLength: 50, nullable: true),
                    RegistroAtivo = table.Column<bool>(nullable: false),
                    UsuarioCodFuncao = table.Column<int>(nullable: false),
                    Login = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    Senha = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    Nome = table.Column<string>(type: "varchar", maxLength: 250, nullable: false),
                    Sobrenome = table.Column<string>(type: "varchar", maxLength: 250, nullable: false),
                    Salario = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_FUNCIONARIO", x => x.FuncionarioID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ADMINISTRADOR");

            migrationBuilder.DropTable(
                name: "TB_FUNCIONARIO");
        }
    }
}
