using Microsoft.EntityFrameworkCore.Migrations;

namespace CharmosaApp.MVC.Migrations
{
    public partial class Esqueleto3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_CLIENTE_TB_PRODUTO_ProdutoID",
                table: "TB_CLIENTE");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PRODUTO_TB_USUARIO_UsuarioBaseID",
                table: "TB_PRODUTO");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_TELEFONE_TB_ADMINISTRADOR_AdministradorAdmistradorID",
                table: "TB_TELEFONE");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_TELEFONE_TB_CLIENTE_ClienteID",
                table: "TB_TELEFONE");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_TELEFONE_TB_FUNCIONARIO_FuncionarioID",
                table: "TB_TELEFONE");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_TELEFONE_TB_USUARIO_UsuarioID",
                table: "TB_TELEFONE");

            migrationBuilder.DropIndex(
                name: "IX_TB_TELEFONE_AdministradorAdmistradorID",
                table: "TB_TELEFONE");

            migrationBuilder.DropIndex(
                name: "IX_TB_TELEFONE_ClienteID",
                table: "TB_TELEFONE");

            migrationBuilder.DropIndex(
                name: "IX_TB_TELEFONE_FuncionarioID",
                table: "TB_TELEFONE");

            migrationBuilder.DropIndex(
                name: "IX_TB_TELEFONE_UsuarioID",
                table: "TB_TELEFONE");

            migrationBuilder.DropIndex(
                name: "IX_TB_PRODUTO_UsuarioBaseID",
                table: "TB_PRODUTO");

            migrationBuilder.DropIndex(
                name: "IX_TB_CLIENTE_ProdutoID",
                table: "TB_CLIENTE");

            migrationBuilder.DropColumn(
                name: "AdministradorAdmistradorID",
                table: "TB_TELEFONE");

            migrationBuilder.DropColumn(
                name: "ClienteID",
                table: "TB_TELEFONE");

            migrationBuilder.DropColumn(
                name: "FuncionarioID",
                table: "TB_TELEFONE");

            migrationBuilder.DropColumn(
                name: "UsuarioBaseID",
                table: "TB_PRODUTO");

            migrationBuilder.DropColumn(
                name: "ProdutoID",
                table: "TB_CLIENTE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdministradorAdmistradorID",
                table: "TB_TELEFONE",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteID",
                table: "TB_TELEFONE",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FuncionarioID",
                table: "TB_TELEFONE",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioBaseID",
                table: "TB_PRODUTO",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoID",
                table: "TB_CLIENTE",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_TB_PRODUTO_UsuarioBaseID",
                table: "TB_PRODUTO",
                column: "UsuarioBaseID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CLIENTE_ProdutoID",
                table: "TB_CLIENTE",
                column: "ProdutoID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CLIENTE_TB_PRODUTO_ProdutoID",
                table: "TB_CLIENTE",
                column: "ProdutoID",
                principalTable: "TB_PRODUTO",
                principalColumn: "ProdutoID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PRODUTO_TB_USUARIO_UsuarioBaseID",
                table: "TB_PRODUTO",
                column: "UsuarioBaseID",
                principalTable: "TB_USUARIO",
                principalColumn: "UsuarioBaseID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_TELEFONE_TB_ADMINISTRADOR_AdministradorAdmistradorID",
                table: "TB_TELEFONE",
                column: "AdministradorAdmistradorID",
                principalTable: "TB_ADMINISTRADOR",
                principalColumn: "AdmistradorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_TELEFONE_TB_CLIENTE_ClienteID",
                table: "TB_TELEFONE",
                column: "ClienteID",
                principalTable: "TB_CLIENTE",
                principalColumn: "ClienteID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_TELEFONE_TB_FUNCIONARIO_FuncionarioID",
                table: "TB_TELEFONE",
                column: "FuncionarioID",
                principalTable: "TB_FUNCIONARIO",
                principalColumn: "FuncionarioID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_TELEFONE_TB_USUARIO_UsuarioID",
                table: "TB_TELEFONE",
                column: "UsuarioID",
                principalTable: "TB_USUARIO",
                principalColumn: "UsuarioBaseID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
