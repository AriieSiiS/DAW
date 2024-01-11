using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PO03_01.Migrations
{
    public partial class SeedingIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a52f449-7b68-48df-9ca3-e309b8b3b912", "9c688cd1-de2a-4ad8-936f-24427aa5d3f7", "Admin", "ADMIN" },
                    { "15718721-8333-46ce-9280-5960a304fe86", "0fc919ac-a641-40d9-9928-2627f8ae3739", "Comercial", "COMERCIAL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "isActive" },
                values: new object[,]
                {
                    { "0b17350b-e5a0-45ef-b1fe-4a16146ba293", 0, "250328f9-15bb-4032-996d-3794045c9131", "admin@musicstore.com", false, "Usuario Admin", false, null, "ADMIN@MUSICSTORE.COM", "ADMIN@MUSICSTORE.COM", "AQAAAAEAACcQAAAAEHqDDK+c0STYNpcD6r8S2VMOmQDCf8/AKFL550nF+dQYGyVwMKvIf1k4F15AB6hcTQ==", null, false, "300c329f-a50f-4532-a1e8-6da5b323708f", false, "admin@musicstore.com", true },
                    { "1c38eb6d-a836-4bdb-9976-bc746859b6b9", 0, "38bb4924-76a6-4761-add7-480fe28b8b62", "comercial2@musicstore.com", false, "Usuario Normal Dos", false, null, "COMERCIAL2@MUSICSTORE.COM", "COMERCIAL2@MUSICSTORE.COM", "AQAAAAEAACcQAAAAECJvME6jU/577Of+tPspusk638lTrHCDrVyuN1NuM8qnd0jw6uHp8pFmKGMXEqJXog==", null, false, "4071d5f7-7487-43a9-b615-3a7f698c1bd8", false, "comercial2@musicstore.com", true },
                    { "dd8646a5-8db9-4d3d-bb25-8416f1277574", 0, "ce4408ee-7057-4f78-a7f2-bc64b7cbf3cf", "comercial1@musicstore.com", false, "Usuario Normal Uno", false, null, "COMERCIAL1@MUSICSTORE.COM", "COMERCIAL1@MUSICSTORE.COM", "AQAAAAEAACcQAAAAEIj7kSmDrBrkhdH4hfJaPQYbJ6cP8v3Cd8njVMl3SrV653/Pso3FMbpii47DOOgAAQ==", null, false, "3c3161b0-dfa0-4d65-b80a-d7c70232b86e", false, "comercial1@musicstore.com", true }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0a52f449-7b68-48df-9ca3-e309b8b3b912", "0b17350b-e5a0-45ef-b1fe-4a16146ba293" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15718721-8333-46ce-9280-5960a304fe86");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0a52f449-7b68-48df-9ca3-e309b8b3b912", "0b17350b-e5a0-45ef-b1fe-4a16146ba293" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c38eb6d-a836-4bdb-9976-bc746859b6b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd8646a5-8db9-4d3d-bb25-8416f1277574");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a52f449-7b68-48df-9ca3-e309b8b3b912");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b17350b-e5a0-45ef-b1fe-4a16146ba293");
        }
    }
}
