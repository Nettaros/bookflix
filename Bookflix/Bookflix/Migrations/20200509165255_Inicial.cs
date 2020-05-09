using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookflix.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Categoria",
                columns: table => new
                {
                    Nombre = table.Column<string>(nullable: false),
                    MaxPerfiles = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Nombre);
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

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.Nombre);
                });

            migrationBuilder.CreateTable(
                name: "Cuentas",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    Contraseña = table.Column<string>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    NombreCompleto = table.Column<string>(nullable: true),
                    Dni = table.Column<string>(nullable: true),
                    CategoriaNombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuentas", x => x.Email);
                    table.ForeignKey(
                        name: "FK_Cuentas_Categoria_CategoriaNombre",
                        column: x => x.CategoriaNombre,
                        principalTable: "Categoria",
                        principalColumn: "Nombre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    ISBN = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    EditorialNombre = table.Column<string>(nullable: false),
                    AutorNombre = table.Column<string>(nullable: false),
                    FechaPublicacion = table.Column<DateTime>(nullable: false),
                    Sinopsis = table.Column<string>(nullable: false),
                    GeneroNombre = table.Column<string>(nullable: false),
                    Imagen = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.ISBN);
                    table.ForeignKey(
                        name: "FK_Libros_Autores_AutorNombre",
                        column: x => x.AutorNombre,
                        principalTable: "Autores",
                        principalColumn: "Nombre",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Libros_Editoriales_EditorialNombre",
                        column: x => x.EditorialNombre,
                        principalTable: "Editoriales",
                        principalColumn: "Nombre",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Libros_Generos_GeneroNombre",
                        column: x => x.GeneroNombre,
                        principalTable: "Generos",
                        principalColumn: "Nombre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    Nombre = table.Column<string>(nullable: false),
                    SubscriptorId = table.Column<string>(nullable: true),
                    Imagen = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.Nombre);
                    table.ForeignKey(
                        name: "FK_Perfil_Cuentas_SubscriptorId",
                        column: x => x.SubscriptorId,
                        principalTable: "Cuentas",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tarjeta",
                columns: table => new
                {
                    Numero = table.Column<string>(nullable: false),
                    FechaVencimiento = table.Column<DateTime>(nullable: false),
                    CodigoSeguridad = table.Column<byte>(nullable: false),
                    SubscriptorId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarjeta", x => x.Numero);
                    table.ForeignKey(
                        name: "FK_Tarjeta_Cuentas_SubscriptorId",
                        column: x => x.SubscriptorId,
                        principalTable: "Cuentas",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contenido",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Dato = table.Column<byte[]>(nullable: false),
                    FechaPublicacion = table.Column<DateTime>(nullable: false),
                    LibroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contenido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contenido_Libros_LibroId",
                        column: x => x.LibroId,
                        principalTable: "Libros",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PerfilLibros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LibroISBN = table.Column<int>(nullable: false),
                    PerfilId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilLibros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerfilLibros_Libros_LibroISBN",
                        column: x => x.LibroISBN,
                        principalTable: "Libros",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PerfilLibros_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Nombre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reclamos",
                columns: table => new
                {
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    Texto = table.Column<string>(nullable: true),
                    PerfilId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reclamos", x => x.FechaCreacion);
                    table.ForeignKey(
                        name: "FK_Reclamos_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Nombre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reseña",
                columns: table => new
                {
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    Texto = table.Column<string>(nullable: true),
                    PerfilId = table.Column<string>(nullable: true),
                    Puntaje = table.Column<byte>(nullable: false),
                    LibroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reseña", x => x.FechaCreacion);
                    table.ForeignKey(
                        name: "FK_Reseña_Libros_LibroId",
                        column: x => x.LibroId,
                        principalTable: "Libros",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reseña_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Nombre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contenido_LibroId",
                table: "Contenido",
                column: "LibroId");

            migrationBuilder.CreateIndex(
                name: "IX_Cuentas_CategoriaNombre",
                table: "Cuentas",
                column: "CategoriaNombre");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_AutorNombre",
                table: "Libros",
                column: "AutorNombre");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_EditorialNombre",
                table: "Libros",
                column: "EditorialNombre");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_GeneroNombre",
                table: "Libros",
                column: "GeneroNombre");

            migrationBuilder.CreateIndex(
                name: "IX_Perfil_SubscriptorId",
                table: "Perfil",
                column: "SubscriptorId");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilLibros_LibroISBN",
                table: "PerfilLibros",
                column: "LibroISBN");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilLibros_PerfilId",
                table: "PerfilLibros",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Reclamos_PerfilId",
                table: "Reclamos",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Reseña_LibroId",
                table: "Reseña",
                column: "LibroId");

            migrationBuilder.CreateIndex(
                name: "IX_Reseña_PerfilId",
                table: "Reseña",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarjeta_SubscriptorId",
                table: "Tarjeta",
                column: "SubscriptorId",
                unique: true,
                filter: "[SubscriptorId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contenido");

            migrationBuilder.DropTable(
                name: "PerfilLibros");

            migrationBuilder.DropTable(
                name: "Reclamos");

            migrationBuilder.DropTable(
                name: "Reseña");

            migrationBuilder.DropTable(
                name: "Tarjeta");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Perfil");

            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropTable(
                name: "Editoriales");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "Cuentas");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
