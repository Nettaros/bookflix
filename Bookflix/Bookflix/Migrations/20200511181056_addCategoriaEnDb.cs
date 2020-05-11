using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookflix.Migrations
{
    public partial class addCategoriaEnDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptores_Categoria_CategoriaNombre",
                table: "Subscriptores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "Categorias");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "Nombre");

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptores_Categorias_CategoriaNombre",
                table: "Subscriptores",
                column: "CategoriaNombre",
                principalTable: "Categorias",
                principalColumn: "Nombre",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptores_Categorias_CategoriaNombre",
                table: "Subscriptores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.RenameTable(
                name: "Categorias",
                newName: "Categoria");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "Nombre");

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptores_Categoria_CategoriaNombre",
                table: "Subscriptores",
                column: "CategoriaNombre",
                principalTable: "Categoria",
                principalColumn: "Nombre",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
