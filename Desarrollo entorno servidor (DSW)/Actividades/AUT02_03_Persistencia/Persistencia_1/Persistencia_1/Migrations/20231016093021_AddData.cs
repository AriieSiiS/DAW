using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia_1.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "ID", "Age", "Height", "Name", "Position", "Retired", "Team" },
                values: new object[] { 1, 24, 1m, "Alejandro", "Central", true, "Equipo" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
