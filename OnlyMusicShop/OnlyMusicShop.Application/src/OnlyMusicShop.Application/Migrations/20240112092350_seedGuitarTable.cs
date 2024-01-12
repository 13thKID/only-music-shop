using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlyMusicShop.Application.Migrations
{
    /// <inheritdoc />
    public partial class seedGuitarTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guitars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guitars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Guitars",
                columns: new[] { "Id", "Color", "CreateDate", "Description", "Manufacturer", "Model", "Name", "Price", "Type", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Satin Cherry", null, "Gitara elektryczna pół-hollow z przetwornikami skalibrowanymi typu T", "Gibson", "ES-335", "Gibson ES-335 Cherry", 12999m, "Semi-hollow", null },
                    { 2, "Flame Maple", null, "Gitara elektryczna sygnowana przez Guthriego Govana", "Charvel", "Guthrie Govan Signature", "Charvel Guthrie Govan HSH Flame Maple", 16690m, "Strat", null },
                    { 3, "Saphire blue", null, "Gitara elektryczna sygnowana przez Guthriego Govana", "Kiesel", "JB200C", "Jason Becker signature Kiesel", 15999m, "Strat", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guitars");
        }
    }
}
