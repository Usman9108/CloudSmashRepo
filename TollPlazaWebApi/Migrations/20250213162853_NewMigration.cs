using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TollPlazaWebApi.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntryPoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PointName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KMFromZeroPoint = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntryPoints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecialDiscounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Month_Day = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialDiscounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TollEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryPoint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TollEntries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TollRates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TollRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TollExits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    ExitPoint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DistanceTraveled = table.Column<double>(type: "float", nullable: false),
                    TollAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TollExits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TollExits_TollEntries_EntryId",
                        column: x => x.EntryId,
                        principalTable: "TollEntries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "EntryPoints",
                columns: new[] { "Id", "KMFromZeroPoint", "PointName" },
                values: new object[,]
                {
                    { 1, 0, "Zero Point" },
                    { 2, 5, "NS Interchange" },
                    { 3, 10, "Ph4 Interchange" },
                    { 4, 17, "Ferozpur Interchange" },
                    { 5, 24, "Lake City Interchange" },
                    { 6, 29, "Raiwand Interchange" },
                    { 7, 34, "Bahria Interchange" }
                });

            migrationBuilder.InsertData(
                table: "SpecialDiscounts",
                columns: new[] { "Id", "Month_Day", "Name" },
                values: new object[,]
                {
                    { 11, 814, "Independence Day" },
                    { 12, 1225, "Christmas Day" },
                    { 13, 323, "Republic Day" }
                });

            migrationBuilder.InsertData(
                table: "TollRates",
                columns: new[] { "Id", "Name", "Rate" },
                values: new object[,]
                {
                    { 21, "BaseRate", 20.0 },
                    { 22, "DistanceRate", 0.20000000000000001 },
                    { 23, "WeekEndDate", 1.5 },
                    { 24, "NumberPlateDiscountRate", 0.10000000000000001 },
                    { 25, "NationHolidayDiscountRate", 0.5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TollExits_EntryId",
                table: "TollExits",
                column: "EntryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntryPoints");

            migrationBuilder.DropTable(
                name: "SpecialDiscounts");

            migrationBuilder.DropTable(
                name: "TollExits");

            migrationBuilder.DropTable(
                name: "TollRates");

            migrationBuilder.DropTable(
                name: "TollEntries");
        }
    }
}
