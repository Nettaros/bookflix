using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookflix.Migrations
{
    public partial class separeAdminYsubdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuentas_Categoria_CategoriaNombre",
                table: "Cuentas");

            migrationBuilder.DropForeignKey(
                name: "FK_Perfil_Cuentas_SubscriptorId",
                table: "Perfil");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarjeta_Cuentas_SubscriptorId",
                table: "Tarjeta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cuentas",
                table: "Cuentas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Cuentas");

            migrationBuilder.RenameTable(
                name: "Cuentas",
                newName: "Subscriptores");

            migrationBuilder.RenameIndex(
                name: "IX_Cuentas_CategoriaNombre",
                table: "Subscriptores",
                newName: "IX_Subscriptores_CategoriaNombre");

            migrationBuilder.AlterColumn<string>(
                name: "NombreCompleto",
                table: "Subscriptores",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Dni",
                table: "Subscriptores",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subscriptores",
                table: "Subscriptores",
                column: "Email");

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    Contraseña = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Email);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Perfil_Subscriptores_SubscriptorId",
                table: "Perfil",
                column: "SubscriptorId",
                principalTable: "Subscriptores",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptores_Categoria_CategoriaNombre",
                table: "Subscriptores",
                column: "CategoriaNombre",
                principalTable: "Categoria",
                principalColumn: "Nombre",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjeta_Subscriptores_SubscriptorId",
                table: "Tarjeta",
                column: "SubscriptorId",
                principalTable: "Subscriptores",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perfil_Subscriptores_SubscriptorId",
                table: "Perfil");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptores_Categoria_CategoriaNombre",
                table: "Subscriptores");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarjeta_Subscriptores_SubscriptorId",
                table: "Tarjeta");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subscriptores",
                table: "Subscriptores");

            migrationBuilder.RenameTable(
                name: "Subscriptores",
                newName: "Cuentas");

            migrationBuilder.RenameIndex(
                name: "IX_Subscriptores_CategoriaNombre",
                table: "Cuentas",
                newName: "IX_Cuentas_CategoriaNombre");

            migrationBuilder.AlterColumn<string>(
                name: "NombreCompleto",
                table: "Cuentas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Dni",
                table: "Cuentas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Cuentas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cuentas",
                table: "Cuentas",
                column: "Email");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuentas_Categoria_CategoriaNombre",
                table: "Cuentas",
                column: "CategoriaNombre",
                principalTable: "Categoria",
                principalColumn: "Nombre",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Perfil_Cuentas_SubscriptorId",
                table: "Perfil",
                column: "SubscriptorId",
                principalTable: "Cuentas",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjeta_Cuentas_SubscriptorId",
                table: "Tarjeta",
                column: "SubscriptorId",
                principalTable: "Cuentas",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
