using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBanca.Migrations
{
    public partial class ColaboradorID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ColaboradorID",
                table: "Vendas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_ColaboradorID",
                table: "Vendas",
                column: "ColaboradorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_PessoaFisica_ColaboradorID",
                table: "Vendas",
                column: "ColaboradorID",
                principalTable: "PessoaFisica",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_PessoaFisica_ColaboradorID",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_ColaboradorID",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "ColaboradorID",
                table: "Vendas");
        }
    }
}
