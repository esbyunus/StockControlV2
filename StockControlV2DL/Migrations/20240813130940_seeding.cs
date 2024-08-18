using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockControlV2DL.Migrations
{
    /// <inheritdoc />
    public partial class seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CPUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CoreCount = table.Column<int>(type: "int", nullable: false),
                    ClockSpeed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BrandType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GPUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Memory = table.Column<int>(type: "int", nullable: false),
                    CoreClock = table.Column<int>(type: "int", nullable: false),
                    BrandType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotherBoards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Socket = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FormFactor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BrandType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotherBoards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RAMs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    BrandType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CPUs",
                columns: new[] { "Id", "BrandType", "ClockSpeed", "CoreCount", "CreatedDate", "IsDeleted" },
                values: new object[] { 1, "Intel CPU", 3.6m, 8, new DateTime(2024, 8, 13, 16, 9, 40, 446, DateTimeKind.Local).AddTicks(1742), false });

            migrationBuilder.InsertData(
                table: "GPUs",
                columns: new[] { "Id", "BrandType", "CoreClock", "CreatedDate", "IsDeleted", "Memory" },
                values: new object[] { 1, "Asus GPU", 1600, new DateTime(2024, 8, 13, 16, 9, 40, 446, DateTimeKind.Local).AddTicks(1836), false, 8 });

            migrationBuilder.InsertData(
                table: "MotherBoards",
                columns: new[] { "Id", "BrandType", "CreatedDate", "FormFactor", "IsDeleted", "Socket" },
                values: new object[] { 1, " Gigabyte MotherBoard", new DateTime(2024, 8, 13, 16, 9, 40, 446, DateTimeKind.Local).AddTicks(1864), "ATX", false, "LGA1151" });

            migrationBuilder.InsertData(
                table: "RAMs",
                columns: new[] { "Id", "BrandType", "Capacity", "CreatedDate", "IsDeleted", "Speed" },
                values: new object[] { 1, "Corsair Ram", 16, new DateTime(2024, 8, 13, 16, 9, 40, 446, DateTimeKind.Local).AddTicks(1850), false, 3200 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CPUs");

            migrationBuilder.DropTable(
                name: "GPUs");

            migrationBuilder.DropTable(
                name: "MotherBoards");

            migrationBuilder.DropTable(
                name: "RAMs");
        }
    }
}
