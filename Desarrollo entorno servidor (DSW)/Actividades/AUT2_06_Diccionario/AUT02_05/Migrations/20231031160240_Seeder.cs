using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AUT02_05.Migrations
{
    public partial class Seeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2ccaf129-4132-49d2-91d4-61218fd16fba", "34f3bdf2-5edd-461b-b168-1d39ff6c526c", "basic", "BASIC" },
                    { "4bd169da-ece7-440c-88b6-c00d5544dd63", "e671655c-2a87-4042-b057-a2483cd916e6", "premium", "PREMIUM" },
                    { "bf82e632-046c-4be1-9e67-6d26ea079d37", "51061f63-eae2-4e52-b79f-4aea0b5bfc4d", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5a7420ea-ee0d-4947-bf3f-0fd21eb7bbea", 0, "e5310243-0035-4ad8-ae65-9116b5b1d6f5", "admin@diccionario.com", false, false, null, "ADMIN@DICCIONARIO.COM", "ADMIN@DICCIONARIO.COM", "AQAAAAEAACcQAAAAEHGe2eHOSy1+9cHoKgYx969m4i/tJgXKMhHGV0UqS/iKhfgMN1mBm213w6WAKVWZjg==", null, false, "6b162440-e4ea-4e17-b0f4-8d08e4748746", false, "admin@diccionario.com" },
                    { "7b0edcf5-5365-421c-956e-b9fc0ecc546c", 0, "455d37cb-b8d5-42a1-a790-1d4ac312ccb0", "premium@diccionario.com", false, false, null, "PREMIUM@DICCIONARIO.COM", "PREMIUM@DICCIONARIO.COM", "AQAAAAEAACcQAAAAEG1FS75W+iEFyPXfYUKxJNBzSonV+l/mHB1ovE7cSSCDmv+0Q0NwaHDjZ4rQ0KaTQQ==", null, false, "2dea100e-d32e-4747-9d2b-0df73b437def", false, "premium@diccionario.com" },
                    { "b306afbd-b7c2-4d58-ba24-4ecc3f5b8d6b", 0, "c42baa6a-db7b-43e9-83bc-ededdf9d5452", "basic@diccionario.com", false, false, null, "BASIC@DICCIONARIO.COM", "BASIC@DICCIONARIO.COM", "AQAAAAEAACcQAAAAEHi973wQxMMfSfgZZr4iF6H8rOCHTbqLsub85mhPNsTy6TokkSWJeriOhrKfTK7AiA==", null, false, "38cbb9ba-e078-41eb-8556-0ee541eb37e6", false, "basic@diccionario.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bf82e632-046c-4be1-9e67-6d26ea079d37", "5a7420ea-ee0d-4947-bf3f-0fd21eb7bbea" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4bd169da-ece7-440c-88b6-c00d5544dd63", "7b0edcf5-5365-421c-956e-b9fc0ecc546c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2ccaf129-4132-49d2-91d4-61218fd16fba", "b306afbd-b7c2-4d58-ba24-4ecc3f5b8d6b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bf82e632-046c-4be1-9e67-6d26ea079d37", "5a7420ea-ee0d-4947-bf3f-0fd21eb7bbea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4bd169da-ece7-440c-88b6-c00d5544dd63", "7b0edcf5-5365-421c-956e-b9fc0ecc546c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2ccaf129-4132-49d2-91d4-61218fd16fba", "b306afbd-b7c2-4d58-ba24-4ecc3f5b8d6b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ccaf129-4132-49d2-91d4-61218fd16fba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4bd169da-ece7-440c-88b6-c00d5544dd63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf82e632-046c-4be1-9e67-6d26ea079d37");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a7420ea-ee0d-4947-bf3f-0fd21eb7bbea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b0edcf5-5365-421c-956e-b9fc0ecc546c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b306afbd-b7c2-4d58-ba24-4ecc3f5b8d6b");
        }
    }
}
