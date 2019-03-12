using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CharmosaApp.MVC.Migrations
{
    public partial class Esqueleto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ROUPA",
                columns: table => new
                {
                    RoupaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    LogInInclusao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LogInAlteracao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RegistroAtivo = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar", maxLength: 250, nullable: false),
                    TamanhoRoupa = table.Column<int>(nullable: false),
                    TipoRoupa = table.Column<int>(nullable: false),
                    TipoProduto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ROUPA", x => x.RoupaID);
                });

            migrationBuilder.CreateTable(
                name: "TB_USUARIO",
                columns: table => new
                {
                    UsuarioBaseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    LogInInclusao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LogInAlteracao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RegistroAtivo = table.Column<int>(nullable: false),
                    UsuarioID = table.Column<int>(nullable: false),
                    UsuarioFuncao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIO", x => x.UsuarioBaseID);
                });

            migrationBuilder.CreateTable(
                name: "TB_TELEFONE",
                columns: table => new
                {
                    TelefoneID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    LogInInclusao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LogInAlteracao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RegistroAtivo = table.Column<int>(nullable: false),
                    UsuarioID = table.Column<int>(nullable: false),
                    DDD = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    AdministradorAdmistradorID = table.Column<int>(nullable: true),
                    ClienteID = table.Column<int>(nullable: true),
                    FuncionarioID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_TELEFONE", x => x.TelefoneID);
                    table.ForeignKey(
                        name: "FK_TB_TELEFONE_TB_USUARIO_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "TB_USUARIO",
                        principalColumn: "UsuarioBaseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_ADMINISTRADOR",
                columns: table => new
                {
                    AdmistradorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    LogInInclusao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LogInAlteracao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RegistroAtivo = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TelefoneID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ADMINISTRADOR", x => x.AdmistradorID);
                    table.ForeignKey(
                        name: "FK_TB_ADMINISTRADOR_TB_TELEFONE_TelefoneID",
                        column: x => x.TelefoneID,
                        principalTable: "TB_TELEFONE",
                        principalColumn: "TelefoneID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_FUNCIONARIO",
                columns: table => new
                {
                    FuncionarioID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    LogInInclusao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LogInAlteracao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RegistroAtivo = table.Column<int>(nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TelefoneID = table.Column<int>(nullable: true),
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
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Salario = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_FUNCIONARIO", x => x.FuncionarioID);
                    table.ForeignKey(
                        name: "FK_TB_FUNCIONARIO_TB_TELEFONE_TelefoneID",
                        column: x => x.TelefoneID,
                        principalTable: "TB_TELEFONE",
                        principalColumn: "TelefoneID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_PRODUTO",
                columns: table => new
                {
                    ProdutoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    LogInInclusao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LogInAlteracao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RegistroAtivo = table.Column<int>(nullable: false),
                    MercadoriaID = table.Column<int>(nullable: false),
                    TipoProduto = table.Column<int>(nullable: false),
                    ValorUnidade = table.Column<double>(nullable: false),
                    QuantidadeEstoque = table.Column<int>(nullable: false),
                    QuantidadeReservada = table.Column<int>(nullable: false),
                    ClienteID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PRODUTO", x => x.ProdutoID);
                });

            migrationBuilder.CreateTable(
                name: "TB_CARRINHO",
                columns: table => new
                {
                    CarrinhoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    LogInInclusao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LogInAlteracao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RegistroAtivo = table.Column<int>(nullable: false),
                    UsuarioID = table.Column<int>(nullable: false),
                    ProdutoID = table.Column<int>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    SubTotal = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CARRINHO", x => x.CarrinhoID);
                    table.ForeignKey(
                        name: "FK_TB_CARRINHO_TB_PRODUTO_ProdutoID",
                        column: x => x.ProdutoID,
                        principalTable: "TB_PRODUTO",
                        principalColumn: "ProdutoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_CARRINHO_TB_USUARIO_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "TB_USUARIO",
                        principalColumn: "UsuarioBaseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_CLIENTE",
                columns: table => new
                {
                    ClienteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    LogInInclusao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LogInAlteracao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RegistroAtivo = table.Column<int>(nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TelefoneID = table.Column<int>(nullable: true),
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
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    ProdutoID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CLIENTE", x => x.ClienteID);
                    table.ForeignKey(
                        name: "FK_TB_CLIENTE_TB_PRODUTO_ProdutoID",
                        column: x => x.ProdutoID,
                        principalTable: "TB_PRODUTO",
                        principalColumn: "ProdutoID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_CLIENTE_TB_TELEFONE_TelefoneID",
                        column: x => x.TelefoneID,
                        principalTable: "TB_TELEFONE",
                        principalColumn: "TelefoneID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ADMINISTRADOR_TelefoneID",
                table: "TB_ADMINISTRADOR",
                column: "TelefoneID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CARRINHO_ProdutoID",
                table: "TB_CARRINHO",
                column: "ProdutoID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CARRINHO_UsuarioID",
                table: "TB_CARRINHO",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CLIENTE_ProdutoID",
                table: "TB_CLIENTE",
                column: "ProdutoID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CLIENTE_TelefoneID",
                table: "TB_CLIENTE",
                column: "TelefoneID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_FUNCIONARIO_TelefoneID",
                table: "TB_FUNCIONARIO",
                column: "TelefoneID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PRODUTO_ClienteID",
                table: "TB_PRODUTO",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_TELEFONE_AdministradorAdmistradorID",
                table: "TB_TELEFONE",
                column: "AdministradorAdmistradorID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_TELEFONE_ClienteID",
                table: "TB_TELEFONE",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_TELEFONE_FuncionarioID",
                table: "TB_TELEFONE",
                column: "FuncionarioID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_TELEFONE_UsuarioID",
                table: "TB_TELEFONE",
                column: "UsuarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_TELEFONE_TB_CLIENTE_ClienteID",
                table: "TB_TELEFONE",
                column: "ClienteID",
                principalTable: "TB_CLIENTE",
                principalColumn: "ClienteID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_TELEFONE_TB_ADMINISTRADOR_AdministradorAdmistradorID",
                table: "TB_TELEFONE",
                column: "AdministradorAdmistradorID",
                principalTable: "TB_ADMINISTRADOR",
                principalColumn: "AdmistradorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_TELEFONE_TB_FUNCIONARIO_FuncionarioID",
                table: "TB_TELEFONE",
                column: "FuncionarioID",
                principalTable: "TB_FUNCIONARIO",
                principalColumn: "FuncionarioID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PRODUTO_TB_CLIENTE_ClienteID",
                table: "TB_PRODUTO",
                column: "ClienteID",
                principalTable: "TB_CLIENTE",
                principalColumn: "ClienteID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ADMINISTRADOR_TB_TELEFONE_TelefoneID",
                table: "TB_ADMINISTRADOR");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_CLIENTE_TB_TELEFONE_TelefoneID",
                table: "TB_CLIENTE");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_FUNCIONARIO_TB_TELEFONE_TelefoneID",
                table: "TB_FUNCIONARIO");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_CLIENTE_TB_PRODUTO_ProdutoID",
                table: "TB_CLIENTE");

            migrationBuilder.DropTable(
                name: "TB_CARRINHO");

            migrationBuilder.DropTable(
                name: "TB_ROUPA");

            migrationBuilder.DropTable(
                name: "TB_TELEFONE");

            migrationBuilder.DropTable(
                name: "TB_ADMINISTRADOR");

            migrationBuilder.DropTable(
                name: "TB_FUNCIONARIO");

            migrationBuilder.DropTable(
                name: "TB_USUARIO");

            migrationBuilder.DropTable(
                name: "TB_PRODUTO");

            migrationBuilder.DropTable(
                name: "TB_CLIENTE");
        }
    }
}
