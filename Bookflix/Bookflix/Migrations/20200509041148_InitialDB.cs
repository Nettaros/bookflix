using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookflix.Migrations
{
    public partial class InitialDB : Migration
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
                    NombreUsuario = table.Column<string>(nullable: false),
                    Contraseña = table.Column<string>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    NombreCompleto = table.Column<string>(nullable: true),
                    Dni = table.Column<string>(nullable: true),
                    CategoriaNombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuentas", x => x.NombreUsuario);
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
                    SubscriptorNombreUsuario = table.Column<string>(nullable: true),
                    Imagen = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.Nombre);
                    table.ForeignKey(
                        name: "FK_Perfil_Cuentas_SubscriptorNombreUsuario",
                        column: x => x.SubscriptorNombreUsuario,
                        principalTable: "Cuentas",
                        principalColumn: "NombreUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tarjeta",
                columns: table => new
                {
                    Numero = table.Column<string>(nullable: false),
                    FechaVencimiento = table.Column<DateTime>(nullable: false),
                    CodigoSeguridad = table.Column<byte>(nullable: false),
                    SubscriptorNombreUsuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarjeta", x => x.Numero);
                    table.ForeignKey(
                        name: "FK_Tarjeta_Cuentas_SubscriptorNombreUsuario",
                        column: x => x.SubscriptorNombreUsuario,
                        principalTable: "Cuentas",
                        principalColumn: "NombreUsuario",
                        onDelete: ReferentialAction.Cascade);
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
                    LibroISBN = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contenido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contenido_Libros_LibroISBN",
                        column: x => x.LibroISBN,
                        principalTable: "Libros",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reclamos",
                columns: table => new
                {
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    Texto = table.Column<string>(nullable: true),
                    PerfilNombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reclamos", x => x.FechaCreacion);
                    table.ForeignKey(
                        name: "FK_Reclamos_Perfil_PerfilNombre",
                        column: x => x.PerfilNombre,
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
                    PerfilNombre = table.Column<string>(nullable: true),
                    Puntaje = table.Column<byte>(nullable: false),
                    LibroISBN = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reseña", x => x.FechaCreacion);
                    table.ForeignKey(
                        name: "FK_Reseña_Libros_LibroISBN",
                        column: x => x.LibroISBN,
                        principalTable: "Libros",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reseña_Perfil_PerfilNombre",
                        column: x => x.PerfilNombre,
                        principalTable: "Perfil",
                        principalColumn: "Nombre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contenido_LibroISBN",
                table: "Contenido",
                column: "LibroISBN");

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
                name: "IX_Perfil_SubscriptorNombreUsuario",
                table: "Perfil",
                column: "SubscriptorNombreUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Reclamos_PerfilNombre",
                table: "Reclamos",
                column: "PerfilNombre");

            migrationBuilder.CreateIndex(
                name: "IX_Reseña_LibroISBN",
                table: "Reseña",
                column: "LibroISBN");

            migrationBuilder.CreateIndex(
                name: "IX_Reseña_PerfilNombre",
                table: "Reseña",
                column: "PerfilNombre");

            migrationBuilder.CreateIndex(
                name: "IX_Tarjeta_SubscriptorNombreUsuario",
                table: "Tarjeta",
                column: "SubscriptorNombreUsuario",
                unique: true,
                filter: "[SubscriptorNombreUsuario] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contenido");

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
