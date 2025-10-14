using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class Testmore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "4e2d4b8c-757b-4fd0-81e4-51586fcf452e", 0, "080e330a-5e89-41f8-b2ff-68aca671cea8", "user2@test.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEPrEC5c67gOJxEW9DJIT/TJVax0e2nMU3fpv69H79fz0jQi10z77bFKTdbcma8A5Hg==", null, false, "dd93a612-e7a6-42ed-87bf-78eedfaf8db0", false, "user2@test.com" },
                    { "e616b69f-5459-48bf-ba4e-55ae4c68acde", 0, "c2f36d10-2386-4be1-a92d-3eb33c341656", "user1@test.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEIRcn2GRoORIIsLG4Tjs8Y5h1VH02JTgaM23CFCcWX0R5ppBrWQMFxTgawhEgiDkbw==", null, false, "ad063527-a345-41b6-a705-07a95c138eb3", false, "user1@test.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e2d4b8c-757b-4fd0-81e4-51586fcf452e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e616b69f-5459-48bf-ba4e-55ae4c68acde");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3f207217-f95c-4cb4-97ab-71a786264ff2", 0, "d53cc1d0-c62e-45fc-b253-f48c86c2fc0d", "", true, false, null, null, null, "AQAAAAIAAYagAAAAEOj4uh5WVtGOBMBzdpkeu2qyYI4PL9NFFL339P9VrWaz8urV2R10abHT8SJ/UTF8nw==", null, false, "71bade39-3cb4-4325-8e1c-e2256d9dbc80", false, "user1@test.com" },
                    { "68569ad5-f8b7-47e1-89cb-0afa3b0393ee", 0, "d6acd28d-3f6e-44a6-ad5b-fc2ee2bd856d", "", true, false, null, null, null, "AQAAAAIAAYagAAAAEDIQSeXgrui/+/t7cpWOilSSWe9GlLI4zqSng8IwdrU9gmzT6gi72nL9QSWVb8FUUw==", null, false, "f77cd91b-8f97-4fcd-8eac-556d43abdf58", false, "user2@test.com" }
                });
        }
    }
}
