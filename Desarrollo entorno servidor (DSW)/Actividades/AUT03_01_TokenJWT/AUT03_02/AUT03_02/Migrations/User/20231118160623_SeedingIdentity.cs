using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AUT03_02.Migrations.User
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
                    { "3fe308f1-ead5-40d9-8666-45c290d155ef", "6f6ba473-8fd9-4aef-a925-9491bd007063", "basic", "BASIC" },
                    { "66cc5737-60df-4ce3-b261-e9a5a15d804c", "3f733471-cb61-4473-b3a4-f083c3f8084f", "admin", "ADMIN" },
                    { "a2c65cf8-6326-4a14-96fc-e54169f198e1", "228e556b-56f1-4c28-9402-5b459f3f779f", "premium", "PREMIUM" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0132bab4-e49b-4cbe-ac94-f3eb394d2c2f", 0, "bc55b440-abac-4cb1-a52e-a69949cb8982", "admin@videojuego.com", false, false, null, "ADMIN@VIDEOJUEGO.COM", "ADMIN@VIDEOJUEGO.COM", "AQAAAAEAACcQAAAAEIRXQGJPiU73YdHCvEteBKuMyUaewfbPIq2zd/TPFPRwu/J7v45dUSHyDGXFYUeSNQ==", null, false, "a743919d-88cb-4bfe-8e94-3bc522924948", false, "admin@videojuego.com" },
                    { "0398ff1f-36b9-494c-ba99-89b645e2507a", 0, "f12c6521-459e-4318-8076-b89cecc2e992", "basic@videojuego.com", false, false, null, "BASIC@VIDEOJUEGO.COM", "BASIC@VIDEOJUEGO.COM", "AQAAAAEAACcQAAAAELtsM4Nv0YPmtObMxj+csd+eoC0qNf9fhUwY84rEfUUV5qCmLDeGpHhqkb8eJyk0Ug==", null, false, "e22f8127-ff4a-436a-9ad1-e0a224089257", false, "basic@videojuego.com" },
                    { "84a8e332-e77f-410f-8ed3-9b03a60d99ef", 0, "c2f8a4c3-92a0-4d86-8fc1-38a74889e8bc", "premium@videojuego.com", false, false, null, "PREMIUM@VIDEOJUEGO.COM", "PREMIUM@VIDEOJUEGO.COM", "AQAAAAEAACcQAAAAEOrxqStlduQ3+avXPZcC0saRXJVf+HeyYT6HIsACJlHIsiTjG7JSLZR86q3JMkh1yA==", null, false, "ddbdc5bb-38ce-4d47-b641-ee3770c24590", false, "premium@videojuego.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "66cc5737-60df-4ce3-b261-e9a5a15d804c", "0132bab4-e49b-4cbe-ac94-f3eb394d2c2f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3fe308f1-ead5-40d9-8666-45c290d155ef", "0398ff1f-36b9-494c-ba99-89b645e2507a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a2c65cf8-6326-4a14-96fc-e54169f198e1", "84a8e332-e77f-410f-8ed3-9b03a60d99ef" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "66cc5737-60df-4ce3-b261-e9a5a15d804c", "0132bab4-e49b-4cbe-ac94-f3eb394d2c2f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3fe308f1-ead5-40d9-8666-45c290d155ef", "0398ff1f-36b9-494c-ba99-89b645e2507a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a2c65cf8-6326-4a14-96fc-e54169f198e1", "84a8e332-e77f-410f-8ed3-9b03a60d99ef" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fe308f1-ead5-40d9-8666-45c290d155ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66cc5737-60df-4ce3-b261-e9a5a15d804c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2c65cf8-6326-4a14-96fc-e54169f198e1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0132bab4-e49b-4cbe-ac94-f3eb394d2c2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0398ff1f-36b9-494c-ba99-89b645e2507a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84a8e332-e77f-410f-8ed3-9b03a60d99ef");
        }
    }
}
