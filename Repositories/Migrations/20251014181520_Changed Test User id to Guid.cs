using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class ChangedTestUseridtoGuid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00a396ff-12bf-40a8-942b-fdf0a08e9cfd", 0, "b3dcceda-e1c9-4447-a012-97229d18a0fc", "", true, false, null, null, null, "AQAAAAIAAYagAAAAEHWchc/ZuBYmBwg8sc/eQztreW4gV09MUpZM7xXoTc6hEsNl4EAhX0qD0FI7yXPKaA==", null, false, "0b010298-39ed-47c3-ac32-ba2b6c035d05", false, "user1@test.com" },
                    { "40df613e-be04-4ee5-a60e-59c518e95f94", 0, "0ffede52-3ed1-4b4e-bbf8-a5080a6b7866", "", true, false, null, null, null, "AQAAAAIAAYagAAAAEDM39M8seyjlPsxVWqiqFlXWPgLcVL4FMpQYEn2nmkckvk1FeiVMCI25vpdRhOvnkA==", null, false, "2d72e6df-9a5c-44a3-a96d-d7854ee34de6", false, "User2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00a396ff-12bf-40a8-942b-fdf0a08e9cfd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40df613e-be04-4ee5-a60e-59c518e95f94");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "98b2f43a-a3d6-4c62-a493-9f3b2fd375f9", "", true, false, null, null, null, "AQAAAAIAAYagAAAAEJ16bOx5D9gyK3OVIvtTMcIs5/yuVROsx2ggVTpe8ALLZQbo4FcyjtP5qfzd25byhA==", null, false, "4f60f177-0ade-4b62-addf-ea9e2ab61df7", false, "user1@test.com" },
                    { "2", 0, "8316ac3a-9ba5-4e2b-8a41-f61a13efad07", "", true, false, null, null, null, "AQAAAAIAAYagAAAAEJ85ZMvjlYPPdpWU2RpJu11MHxmQDYQxY6AVoB8d1+fs/nkX14dXTYvXlIQV/vbIoA==", null, false, "3c242e31-ea9b-40f4-a20b-eb197305251a", false, "user2@test.com" }
                });
        }
    }
}
