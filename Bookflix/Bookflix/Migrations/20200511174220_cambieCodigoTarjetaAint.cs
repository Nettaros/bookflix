using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookflix.Migrations
{
    public partial class cambieCodigoTarjetaAint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CodigoSeguridad",
                table: "Tarjeta",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "CodigoSeguridad",
                table: "Tarjeta",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
