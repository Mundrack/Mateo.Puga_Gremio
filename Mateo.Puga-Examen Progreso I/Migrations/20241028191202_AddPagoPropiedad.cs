using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mateo.Puga_Examen_Progreso_I.Migrations
{
    /// <inheritdoc />
    public partial class AddPagoPropiedad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MPFechaPublicacion",
                table: "MP");

            migrationBuilder.AddColumn<DateTime>(
                name: "MPFechaLimite",
                table: "MP",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "MPPago",
                table: "MP",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MPFechaLimite",
                table: "MP");

            migrationBuilder.DropColumn(
                name: "MPPago",
                table: "MP");

            migrationBuilder.AddColumn<int>(
                name: "MPFechaPublicacion",
                table: "MP",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
