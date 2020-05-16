using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookflix.Migrations
{
    public partial class LibroEdAutYGenOpcionales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         
            migrationBuilder.AlterColumn<string>(
                name: "GeneroNombre",
                table: "Libros",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "EditorialNombre",
                table: "Libros",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "AutorNombre",
                table: "Libros",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AlterColumn<string>(
                name: "GeneroNombre",
                table: "Libros",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditorialNombre",
                table: "Libros",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AutorNombre",
                table: "Libros",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

        }
    }
}
