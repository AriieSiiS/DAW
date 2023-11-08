using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AUT02_05.Migrations.Diccionario
{
    public partial class Frases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Frases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eng = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false),
                    Esp = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false),
                    EspengId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Frases_Espeng_EspengId",
                        column: x => x.EspengId,
                        principalTable: "Espeng",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Frases_EspengId",
                table: "Frases",
                column: "EspengId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Frases");
        }
    }
}
