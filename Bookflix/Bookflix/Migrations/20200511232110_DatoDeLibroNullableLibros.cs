using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookflix.Migrations
{
    public partial class DatoDeLibroNullableLibros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Libros_Autores_AutorNombre",
                table: "Libros");

            migrationBuilder.DropForeignKey(
                name: "FK_Libros_Editoriales_EditorialNombre",
                table: "Libros");

            migrationBuilder.DropForeignKey(
                name: "FK_Libros_Generos_GeneroNombre",
                table: "Libros");

            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropTable(
                name: "Editoriales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Generos",
                table: "Generos");

            migrationBuilder.RenameTable(
                name: "Generos",
                newName: "DatoDeLibro");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Novedades",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "DatoDeLibro",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DatoDeLibro",
                table: "DatoDeLibro",
                column: "Nombre");

            migrationBuilder.AddForeignKey(
                name: "FK_Libros_DatoDeLibro_AutorNombre",
                table: "Libros",
                column: "AutorNombre",
                principalTable: "DatoDeLibro",
                principalColumn: "Nombre",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Libros_DatoDeLibro_EditorialNombre",
                table: "Libros",
                column: "EditorialNombre",
                principalTable: "DatoDeLibro",
                principalColumn: "Nombre",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Libros_DatoDeLibro_GeneroNombre",
                table: "Libros",
                column: "GeneroNombre",
                principalTable: "DatoDeLibro",
                principalColumn: "Nombre",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Libros_DatoDeLibro_AutorNombre",
                table: "Libros");

            migrationBuilder.DropForeignKey(
                name: "FK_Libros_DatoDeLibro_EditorialNombre",
                table: "Libros");

            migrationBuilder.DropForeignKey(
                name: "FK_Libros_DatoDeLibro_GeneroNombre",
                table: "Libros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DatoDeLibro",
                table: "DatoDeLibro");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "DatoDeLibro");

            migrationBuilder.RenameTable(
                name: "DatoDeLibro",
                newName: "Generos");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Novedades",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Generos",
                table: "Generos",
                column: "Nombre");

            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.Nombre);
                });

            migrationBuilder.CreateTable(
                name: "Editoriales",
                columns: table => new
                {
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editoriales", x => x.Nombre);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Libros_Autores_AutorNombre",
                table: "Libros",
                column: "AutorNombre",
                principalTable: "Autores",
                principalColumn: "Nombre",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Libros_Editoriales_EditorialNombre",
                table: "Libros",
                column: "EditorialNombre",
                principalTable: "Editoriales",
                principalColumn: "Nombre",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Libros_Generos_GeneroNombre",
                table: "Libros",
                column: "GeneroNombre",
                principalTable: "Generos",
                principalColumn: "Nombre",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
