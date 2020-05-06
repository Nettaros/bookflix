using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookflix.Migrations
{
    public partial class ISBNFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contenido_Libros_LibroISBN",
                table: "Contenido");

            migrationBuilder.DropColumn(
                name: "LibroISNB",
                table: "Contenido");

            migrationBuilder.AlterColumn<int>(
                name: "LibroISBN",
                table: "Contenido",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contenido_Libros_LibroISBN",
                table: "Contenido",
                column: "LibroISBN",
                principalTable: "Libros",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contenido_Libros_LibroISBN",
                table: "Contenido");

            migrationBuilder.AlterColumn<int>(
                name: "LibroISBN",
                table: "Contenido",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "LibroISNB",
                table: "Contenido",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Contenido_Libros_LibroISBN",
                table: "Contenido",
                column: "LibroISBN",
                principalTable: "Libros",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
