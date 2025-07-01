using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba_Api.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CatFacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fact = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Palabra1 = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Palabra2 = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Palabra3 = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    GifUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaBusqueda = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatFacts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatFacts");
        }
    }
}
