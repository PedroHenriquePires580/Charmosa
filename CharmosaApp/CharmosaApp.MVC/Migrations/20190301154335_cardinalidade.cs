using Microsoft.EntityFrameworkCore.Migrations;

namespace CharmosaApp.MVC.Migrations
{
    public partial class cardinalidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefone_TB_ADMINISTRADOR_AdministradorAdmistradorID",
                table: "Telefone");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefone_Cliente_ClienteID",
                table: "Telefone");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefone_TB_FUNCIONARIO_FuncionarioID",
                table: "Telefone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Telefone",
                table: "Telefone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.RenameTable(
                name: "Telefone",
                newName: "TB_TELEFONE");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "TB_CLIENTE");

            migrationBuilder.RenameIndex(
                name: "IX_Telefone_FuncionarioID",
                table: "TB_TELEFONE",
                newName: "IX_TB_TELEFONE_FuncionarioID");

            migrationBuilder.RenameIndex(
                name: "IX_Telefone_ClienteID",
                table: "TB_TELEFONE",
                newName: "IX_TB_TELEFONE_ClienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Telefone_AdministradorAdmistradorID",
                table: "TB_TELEFONE",
                newName: "IX_TB_TELEFONE_AdministradorAdmistradorID");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteID",
                table: "TB_TELEFONE",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_TELEFONE",
                table: "TB_TELEFONE",
                column: "TelefoneID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_CLIENTE",
                table: "TB_CLIENTE",
                column: "ClienteID");

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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_TELEFONE_TB_FUNCIONARIO_FuncionarioID",
                table: "TB_TELEFONE",
                column: "FuncionarioID",
                principalTable: "TB_FUNCIONARIO",
                principalColumn: "FuncionarioID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_TELEFONE_TB_ADMINISTRADOR_AdministradorAdmistradorID",
                table: "TB_TELEFONE");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_TELEFONE_TB_CLIENTE_ClienteID",
                table: "TB_TELEFONE");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_TELEFONE_TB_FUNCIONARIO_FuncionarioID",
                table: "TB_TELEFONE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_TELEFONE",
                table: "TB_TELEFONE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_CLIENTE",
                table: "TB_CLIENTE");

            migrationBuilder.RenameTable(
                name: "TB_TELEFONE",
                newName: "Telefone");

            migrationBuilder.RenameTable(
                name: "TB_CLIENTE",
                newName: "Cliente");

            migrationBuilder.RenameIndex(
                name: "IX_TB_TELEFONE_FuncionarioID",
                table: "Telefone",
                newName: "IX_Telefone_FuncionarioID");

            migrationBuilder.RenameIndex(
                name: "IX_TB_TELEFONE_ClienteID",
                table: "Telefone",
                newName: "IX_Telefone_ClienteID");

            migrationBuilder.RenameIndex(
                name: "IX_TB_TELEFONE_AdministradorAdmistradorID",
                table: "Telefone",
                newName: "IX_Telefone_AdministradorAdmistradorID");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteID",
                table: "Telefone",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telefone",
                table: "Telefone",
                column: "TelefoneID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "ClienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefone_TB_ADMINISTRADOR_AdministradorAdmistradorID",
                table: "Telefone",
                column: "AdministradorAdmistradorID",
                principalTable: "TB_ADMINISTRADOR",
                principalColumn: "AdmistradorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefone_Cliente_ClienteID",
                table: "Telefone",
                column: "ClienteID",
                principalTable: "Cliente",
                principalColumn: "ClienteID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefone_TB_FUNCIONARIO_FuncionarioID",
                table: "Telefone",
                column: "FuncionarioID",
                principalTable: "TB_FUNCIONARIO",
                principalColumn: "FuncionarioID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
