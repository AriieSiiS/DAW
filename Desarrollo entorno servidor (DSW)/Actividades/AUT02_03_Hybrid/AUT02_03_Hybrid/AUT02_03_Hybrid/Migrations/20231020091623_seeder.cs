using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AUT02_03_Hybrid.Migrations
{
    /// <inheritdoc />
    public partial class seeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shippers",
                columns: new[] { "ShipperID", "CompanyName", "Phone" },
                values: new object[,]
                {
                    { 1, "Shipper 1", "123-456-7890" },
                    { 2, "Shipper 2", "987-654-3210" }
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "Description", "Name", "ShipperID" },
                values: new object[,]
                {
                    { 1, "Description 1", "Company 1", 1 },
                    { 2, "Description 2", "Company 2", 1 },
                    { 3, "Description 3", "Company 3", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shippers",
                keyColumn: "ShipperID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shippers",
                keyColumn: "ShipperID",
                keyValue: 2);
        }
    }
}
