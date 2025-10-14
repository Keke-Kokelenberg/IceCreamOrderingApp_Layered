using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class ChangedTestdataoncemore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "3f207217-f95c-4cb4-97ab-71a786264ff2", 0, "d53cc1d0-c62e-45fc-b253-f48c86c2fc0d", "", true, false, null, null, null, "AQAAAAIAAYagAAAAEOj4uh5WVtGOBMBzdpkeu2qyYI4PL9NFFL339P9VrWaz8urV2R10abHT8SJ/UTF8nw==", null, false, "71bade39-3cb4-4325-8e1c-e2256d9dbc80", false, "user1@test.com" },
                    { "68569ad5-f8b7-47e1-89cb-0afa3b0393ee", 0, "d6acd28d-3f6e-44a6-ad5b-fc2ee2bd856d", "", true, false, null, null, null, "AQAAAAIAAYagAAAAEDIQSeXgrui/+/t7cpWOilSSWe9GlLI4zqSng8IwdrU9gmzT6gi72nL9QSWVb8FUUw==", null, false, "f77cd91b-8f97-4fcd-8eac-556d43abdf58", false, "user2@test.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f207217-f95c-4cb4-97ab-71a786264ff2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68569ad5-f8b7-47e1-89cb-0afa3b0393ee");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00a396ff-12bf-40a8-942b-fdf0a08e9cfd", 0, "b3dcceda-e1c9-4447-a012-97229d18a0fc", "", true, false, null, null, null, "AQAAAAIAAYagAAAAEHWchc/ZuBYmBwg8sc/eQztreW4gV09MUpZM7xXoTc6hEsNl4EAhX0qD0FI7yXPKaA==", null, false, "0b010298-39ed-47c3-ac32-ba2b6c035d05", false, "user1@test.com" },
                    { "40df613e-be04-4ee5-a60e-59c518e95f94", 0, "0ffede52-3ed1-4b4e-bbf8-a5080a6b7866", "", true, false, null, null, null, "AQAAAAIAAYagAAAAEDM39M8seyjlPsxVWqiqFlXWPgLcVL4FMpQYEn2nmkckvk1FeiVMCI25vpdRhOvnkA==", null, false, "2d72e6df-9a5c-44a3-a96d-d7854ee34de6", false, "User2" }
                });
        }
    }
}
