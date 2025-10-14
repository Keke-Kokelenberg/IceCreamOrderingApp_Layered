using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class Oncemoreuntothebreach : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "46dfa17d-7cc3-4604-9b17-1b9e00d9757f", 0, "0344ca0a-3358-426e-9a33-1ea86bb99a78", "user2@test.com", true, false, null, "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAEMx1LOfXpQh0PSZIoln7BLNcBtiqMu4nX27cjcZznkzAtpJycuEpdGd0o3l/bLMVPQ==", null, false, "a48cc075-f1dd-45a5-a5f5-38f1313b196a", false, "user2@test.com" },
                    { "f08a07b9-dc75-4f07-ae2a-97269e83921a", 0, "010cb3da-f3ae-4036-b5a8-dd479a824266", "user1@test.com", true, false, null, "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAEHjfRhjudZ58e9l68805Kt2MWgGql+0kpwxgtQ+aeVEXB8+H6PjpHLHc/9rNfASUNw==", null, false, "715e0fa1-26d8-4190-8f47-914f0308db25", false, "user1@test.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46dfa17d-7cc3-4604-9b17-1b9e00d9757f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f08a07b9-dc75-4f07-ae2a-97269e83921a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4e2d4b8c-757b-4fd0-81e4-51586fcf452e", 0, "080e330a-5e89-41f8-b2ff-68aca671cea8", "user2@test.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEPrEC5c67gOJxEW9DJIT/TJVax0e2nMU3fpv69H79fz0jQi10z77bFKTdbcma8A5Hg==", null, false, "dd93a612-e7a6-42ed-87bf-78eedfaf8db0", false, "user2@test.com" },
                    { "e616b69f-5459-48bf-ba4e-55ae4c68acde", 0, "c2f36d10-2386-4be1-a92d-3eb33c341656", "user1@test.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEIRcn2GRoORIIsLG4Tjs8Y5h1VH02JTgaM23CFCcWX0R5ppBrWQMFxTgawhEgiDkbw==", null, false, "ad063527-a345-41b6-a705-07a95c138eb3", false, "user1@test.com" }
                });
        }
    }
}
