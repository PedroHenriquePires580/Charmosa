using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CharmosaApp.MVC.Migrations
{
    public partial class addingClienteTelefone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "TB_FUNCIONARIO",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "TB_FUNCIONARIO",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "TB_FUNCIONARIO",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "TB_FUNCIONARIO",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "TB_FUNCIONARIO",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "TB_FUNCIONARIO",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Logradouro",
                table: "TB_FUNCIONARIO",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "TB_FUNCIONARIO",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RG",
                table: "TB_FUNCIONARIO",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UF",
                table: "TB_FUNCIONARIO",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "TB_ADMINISTRADOR",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    LogInInclusao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LogInAlteracao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RegistroAtivo = table.Column<int>(nullable: false),
                    UsuarioFuncao = table.Column<int>(nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Sobrenome = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UF = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    RG = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteID);
                });

            migrationBuilder.CreateTable(
                name: "Telefone",
                columns: table => new
                {
                    TelefoneID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    LogInInclusao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LogInAlteracao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RegistroAtivo = table.Column<int>(nullable: false),
                    DDD = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    AdministradorAdmistradorID = table.Column<int>(nullable: true),
                    ClienteID = table.Column<int>(nullable: true),
                    FuncionarioID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefone", x => x.TelefoneID);
                    table.ForeignKey(
                        name: "FK_Telefone_TB_ADMINISTRADOR_AdministradorAdmistradorID",
                        column: x => x.AdministradorAdmistradorID,
                        principalTable: "TB_ADMINISTRADOR",
                        principalColumn: "AdmistradorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Telefone_Cliente_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Telefone_TB_FUNCIONARIO_FuncionarioID",
                        column: x => x.FuncionarioID,
                        principalTable: "TB_FUNCIONARIO",
                        principalColumn: "FuncionarioID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_AdministradorAdmistradorID",
                table: "Telefone",
                column: "AdministradorAdmistradorID");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_ClienteID",
                table: "Telefone",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_FuncionarioID",
                table: "Telefone",
                column: "FuncionarioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Telefone");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "TB_FUNCIONARIO");

            migrationBuilder.DropColumn(
                name: "CEP",
                table: "TB_FUNCIONARIO");

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "TB_FUNCIONARIO");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "TB_FUNCIONARIO");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "TB_FUNCIONARIO");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "TB_FUNCIONARIO");

            migrationBuilder.DropColumn(
                name: "Logradouro",
                table: "TB_FUNCIONARIO");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "TB_FUNCIONARIO");

            migrationBuilder.DropColumn(
                name: "RG",
                table: "TB_FUNCIONARIO");

            migrationBuilder.DropColumn(
                name: "UF",
                table: "TB_FUNCIONARIO");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "TB_ADMINISTRADOR");
        }
    }
}
