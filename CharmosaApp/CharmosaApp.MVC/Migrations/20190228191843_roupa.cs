using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CharmosaApp.MVC.Migrations
{
    public partial class roupa : Migration
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
                    LogInInclusao = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    LogInAlteracao = table.Column<string>(type: "varchar", maxLength: 50, nullable: true),
                    RegistroAtivo = table.Column<bool>(nullable: false),
                    ValorUnidade = table.Column<decimal>(nullable: false),
                    QuantidadeEstoque = table.Column<int>(nullable: false),
                    QuantidadeReservada = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(type: "varchar", maxLength: 250, nullable: false),
                    TamanhoRoupa = table.Column<int>(nullable: false),
                    TipoRoupa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ROUPA", x => x.RoupaID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ROUPA");
        }
    }
}
