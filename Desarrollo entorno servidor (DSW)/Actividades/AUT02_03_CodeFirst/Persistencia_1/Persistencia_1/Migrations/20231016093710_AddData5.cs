using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistencia_1.Migrations
{
    /// <inheritdoc />
    public partial class AddData5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 123);

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "ID", "Age", "Height", "Name", "Position", "Retired", "Team" },
                values: new object[,]
                {
                    { 1, 16, 1.64m, "Hinata Shoyo", "Wing Spiker", false, "Karasuno High School" },
                    { 2, 17, 1.84m, "Kageyama Tobio", "Setter", false, "Karasuno High School" },
                    { 3, 18, 1.87m, "Oikawa Tooru", "Setter", true, "Aoba Johsai High School" },
                    { 4, 17, 1.96m, "Tsukishima Kei", "Blocker", false, "Karasuno High School" },
                    { 5, 18, 1.88m, "Bokuto Koutarou", "Ace", false, "Fukurodani Academy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "ID", "Age", "Height", "Name", "Position", "Retired", "Team" },
                values: new object[] { 123, 24, 1m, "Alejandro", "Central", true, "Equipo" });
        }
    }
}
