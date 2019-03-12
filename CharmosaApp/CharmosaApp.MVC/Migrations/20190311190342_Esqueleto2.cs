using Microsoft.EntityFrameworkCore.Migrations;

namespace CharmosaApp.MVC.Migrations
{
    public partial class Esqueleto2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_TB_PRODUTO_TB_CLIENTE_ClienteID",
                table: "TB_PRODUTO");

            migrationBuilder.DropIndex(
                name: "IX_TB_FUNCIONARIO_TelefoneID",
                table: "TB_FUNCIONARIO");

            migrationBuilder.DropIndex(
                name: "IX_TB_CLIENTE_TelefoneID",
                table: "TB_CLIENTE");

            migrationBuilder.DropIndex(
                name: "IX_TB_ADMINISTRADOR_TelefoneID",
                table: "TB_ADMINISTRADOR");

            migrationBuilder.DropColumn(
                name: "TelefoneID",
                table: "TB_FUNCIONARIO");

            migrationBuilder.DropColumn(
                name: "TelefoneID",
                table: "TB_CLIENTE");

            migrationBuilder.DropColumn(
                name: "TelefoneID",
                table: "TB_ADMINISTRADOR");

            migrationBuilder.RenameColumn(
                name: "ClienteID",
                table: "TB_PRODUTO",
                newName: "UsuarioBaseID");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PRODUTO_ClienteID",
                table: "TB_PRODUTO",
                newName: "IX_TB_PRODUTO_UsuarioBaseID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PRODUTO_TB_USUARIO_UsuarioBaseID",
                table: "TB_PRODUTO",
                column: "UsuarioBaseID",
                principalTable: "TB_USUARIO",
                principalColumn: "UsuarioBaseID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_PRODUTO_TB_USUARIO_UsuarioBaseID",
                table: "TB_PRODUTO");

            migrationBuilder.RenameColumn(
                name: "UsuarioBaseID",
                table: "TB_PRODUTO",
                newName: "ClienteID");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PRODUTO_UsuarioBaseID",
                table: "TB_PRODUTO",
                newName: "IX_TB_PRODUTO_ClienteID");

            migrationBuilder.AddColumn<int>(
                name: "TelefoneID",
                table: "TB_FUNCIONARIO",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TelefoneID",
                table: "TB_CLIENTE",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TelefoneID",
                table: "TB_ADMINISTRADOR",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_FUNCIONARIO_TelefoneID",
                table: "TB_FUNCIONARIO",
                column: "TelefoneID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CLIENTE_TelefoneID",
                table: "TB_CLIENTE",
                column: "TelefoneID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ADMINISTRADOR_TelefoneID",
                table: "TB_ADMINISTRADOR",
                column: "TelefoneID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ADMINISTRADOR_TB_TELEFONE_TelefoneID",
                table: "TB_ADMINISTRADOR",
                column: "TelefoneID",
                principalTable: "TB_TELEFONE",
                principalColumn: "TelefoneID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CLIENTE_TB_TELEFONE_TelefoneID",
                table: "TB_CLIENTE",
                column: "TelefoneID",
                principalTable: "TB_TELEFONE",
                principalColumn: "TelefoneID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_FUNCIONARIO_TB_TELEFONE_TelefoneID",
                table: "TB_FUNCIONARIO",
                column: "TelefoneID",
                principalTable: "TB_TELEFONE",
                principalColumn: "TelefoneID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PRODUTO_TB_CLIENTE_ClienteID",
                table: "TB_PRODUTO",
                column: "ClienteID",
                principalTable: "TB_CLIENTE",
                principalColumn: "ClienteID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
