using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookflix.Migrations
{
    public partial class NovedadConFechas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaOcultacion",
                table: "Novedades",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaPublicacion",
                table: "Novedades",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Generos",
                table: "Generos",
                column: "Nombre");

            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.Nombre);
                });

            migrationBuilder.CreateTable(
                name: "Editoriales",
                columns: table => new
                {
                    Nombre = table.Column<string>(nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "FechaOcultacion",
                table: "Novedades");

            migrationBuilder.DropColumn(
                name: "FechaPublicacion",
                table: "Novedades");

            migrationBuilder.RenameTable(
                name: "Generos",
                newName: "DatoDeLibro");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "DatoDeLibro",
                type: "nvarchar(max)",
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
    }
}
