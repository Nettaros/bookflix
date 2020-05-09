using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookflix.Migrations
{
    public partial class CuentaTieneEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perfil_Cuentas_SubscriptorNombreUsuario",
                table: "Perfil");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarjeta_Cuentas_SubscriptorNombreUsuario",
                table: "Tarjeta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cuentas",
                table: "Cuentas");

            migrationBuilder.DropColumn(
                name: "NombreUsuario",
                table: "Cuentas");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Cuentas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cuentas",
                table: "Cuentas",
                column: "Email");

            migrationBuilder.AddForeignKey(
                name: "FK_Perfil_Cuentas_SubscriptorNombreUsuario",
                table: "Perfil",
                column: "SubscriptorNombreUsuario",
                principalTable: "Cuentas",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjeta_Cuentas_SubscriptorNombreUsuario",
                table: "Tarjeta",
                column: "SubscriptorNombreUsuario",
                principalTable: "Cuentas",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perfil_Cuentas_SubscriptorNombreUsuario",
                table: "Perfil");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarjeta_Cuentas_SubscriptorNombreUsuario",
                table: "Tarjeta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cuentas",
                table: "Cuentas");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Cuentas");

            migrationBuilder.AddColumn<string>(
                name: "NombreUsuario",
                table: "Cuentas",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cuentas",
                table: "Cuentas",
                column: "NombreUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Perfil_Cuentas_SubscriptorNombreUsuario",
                table: "Perfil",
                column: "SubscriptorNombreUsuario",
                principalTable: "Cuentas",
                principalColumn: "NombreUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjeta_Cuentas_SubscriptorNombreUsuario",
                table: "Tarjeta",
                column: "SubscriptorNombreUsuario",
                principalTable: "Cuentas",
                principalColumn: "NombreUsuario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
