using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookflix.Migrations
{
    public partial class NovedadFechaOcultacionRequerida : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaOcultacion",
                table: "Novedades",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaOcultacion",
                table: "Novedades",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
