using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBanca.Migrations
{
    public partial class PromocaoID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Promocao_PromocaoID",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Produto_PromocaoID",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "PromocaoID",
                table: "Produto");

            migrationBuilder.AddColumn<int>(
                name: "ProdutoID",
                table: "Promocao",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Promocao_ProdutoID",
                table: "Promocao",
                column: "ProdutoID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Promocao_Produto_ProdutoID",
                table: "Promocao",
                column: "ProdutoID",
                principalTable: "Produto",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Promocao_Produto_ProdutoID",
                table: "Promocao");

            migrationBuilder.DropIndex(
                name: "IX_Promocao_ProdutoID",
                table: "Promocao");

            migrationBuilder.DropColumn(
                name: "ProdutoID",
                table: "Promocao");

            migrationBuilder.AddColumn<int>(
                name: "PromocaoID",
                table: "Produto",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_PromocaoID",
                table: "Produto",
                column: "PromocaoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Promocao_PromocaoID",
                table: "Produto",
                column: "PromocaoID",
                principalTable: "Promocao",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
