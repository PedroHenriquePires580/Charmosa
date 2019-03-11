using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CharmosaApp.MVC.Migrations
{
    public partial class carrinho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantidadeEstoque",
                table: "TB_ROUPA");

            migrationBuilder.DropColumn(
                name: "QuantidadeReservada",
                table: "TB_ROUPA");

            migrationBuilder.DropColumn(
                name: "ValorUnidade",
                table: "TB_ROUPA");

            migrationBuilder.AlterColumn<string>(
                name: "LogInInclusao",
                table: "TB_ROUPA",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LogInAlteracao",
                table: "TB_ROUPA",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoProduto",
                table: "TB_ROUPA",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoID",
                table: "TB_CLIENTE",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    ProdutoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    LogInInclusao = table.Column<string>(nullable: true),
                    LogInAlteracao = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_Produto", x => x.ProdutoID);
                    table.ForeignKey(
                        name: "FK_Produto_TB_CLIENTE_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "TB_CLIENTE",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carrinho",
                columns: table => new
                {
                    CarrinhoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    LogInInclusao = table.Column<string>(nullable: true),
                    LogInAlteracao = table.Column<string>(nullable: true),
                    RegistroAtivo = table.Column<int>(nullable: false),
                    ClienteID = table.Column<int>(nullable: false),
                    ProdutoID = table.Column<int>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    SubTotal = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrinho", x => x.CarrinhoID);
                    table.ForeignKey(
                        name: "FK_Carrinho_TB_CLIENTE_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "TB_CLIENTE",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carrinho_Produto_ProdutoID",
                        column: x => x.ProdutoID,
                        principalTable: "Produto",
                        principalColumn: "ProdutoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_CLIENTE_ProdutoID",
                table: "TB_CLIENTE",
                column: "ProdutoID");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinho_ClienteID",
                table: "Carrinho",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinho_ProdutoID",
                table: "Carrinho",
                column: "ProdutoID");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_ClienteID",
                table: "Produto",
                column: "ClienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CLIENTE_Produto_ProdutoID",
                table: "TB_CLIENTE",
                column: "ProdutoID",
                principalTable: "Produto",
                principalColumn: "ProdutoID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_CLIENTE_Produto_ProdutoID",
                table: "TB_CLIENTE");

            migrationBuilder.DropTable(
                name: "Carrinho");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_TB_CLIENTE_ProdutoID",
                table: "TB_CLIENTE");

            migrationBuilder.DropColumn(
                name: "TipoProduto",
                table: "TB_ROUPA");

            migrationBuilder.DropColumn(
                name: "ProdutoID",
                table: "TB_CLIENTE");

            migrationBuilder.AlterColumn<string>(
                name: "LogInInclusao",
                table: "TB_ROUPA",
                type: "nvarchar",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LogInAlteracao",
                table: "TB_ROUPA",
                type: "nvarchar",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeEstoque",
                table: "TB_ROUPA",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeReservada",
                table: "TB_ROUPA",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorUnidade",
                table: "TB_ROUPA",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
