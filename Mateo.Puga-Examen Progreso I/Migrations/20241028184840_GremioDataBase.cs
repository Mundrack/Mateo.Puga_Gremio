using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mateo.Puga_Examen_Progreso_I.Migrations
{
    /// <inheritdoc />
    public partial class GremioDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MP",
                columns: table => new
                {
                    MPID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MPNameLibro = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MPDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MPFechaPublicacion = table.Column<int>(type: "int", nullable: false),
                    MPFechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MP", x => x.MPID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MP");
        }
    }
}
