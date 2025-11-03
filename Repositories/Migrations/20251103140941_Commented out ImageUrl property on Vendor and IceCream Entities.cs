using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class CommentedoutImageUrlpropertyonVendorandIceCreamEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba7396a8-2b59-457f-a8f8-496eba4151f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddb914fd-d9e0-4fb8-84d6-12da4d0233fc");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "IceCreamFlavors");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "223c9852-88b2-4f5c-845b-8d61eec95b30", 0, "d20366df-4d94-40f1-9949-ca4676c868aa", "user2@test.com", true, false, null, "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAEA3ISDWyCKhRNhlnzUP7B6nurWdyE1Edf4HJ1GMjyD1Y9WhdVt9C8H7RJUzXZqg8NQ==", null, false, "17ce83b5-feab-4c52-9f7b-502ec9ad9968", false, "user2@test.com" },
                    { "b8260f4a-5c52-4a21-b7da-35ba5a4faba8", 0, "1ebe233f-200b-410a-937b-8d5bba248d55", "user1@test.com", true, false, null, "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAEOfgVuDDQlXygCWUsbb/Ayfjm6Up/rxpNzBFZ9Y2RDU+Sfh1xyHpUw4ah8qdoQ8zGA==", null, false, "61170366-973d-421e-96f8-ab11f30a1ee9", false, "user1@test.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "223c9852-88b2-4f5c-845b-8d61eec95b30");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8260f4a-5c52-4a21-b7da-35ba5a4faba8");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "IceCreamFlavors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ba7396a8-2b59-457f-a8f8-496eba4151f6", 0, "573ceb19-f6a7-43f6-b9eb-a762c8f956b4", "user2@test.com", true, false, null, "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAENgBaWclvmRinJxmwlgoXxC69gr1YMELtavBH6mH9B30HW3TiyTyBYcN1giuVDNbQQ==", null, false, "b283a047-4c23-4c61-bbcf-5dfe7376f732", false, "user2@test.com" },
                    { "ddb914fd-d9e0-4fb8-84d6-12da4d0233fc", 0, "5a3ca6e8-f6bc-423a-b44f-d4f26c141060", "user1@test.com", true, false, null, "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAECGgx+3FZTOi6zjPj6+wJCQ+Iq9Vr2szpYSXk/bDpKzN8ZX8PzFrBDK/TuEc+6KG6Q==", null, false, "edcc480c-6a2d-4bcc-94b2-4878f6d845cb", false, "user1@test.com" }
                });

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 37,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 38,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 39,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 40,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 41,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 42,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 43,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 44,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 45,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 46,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 47,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 48,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 49,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 50,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 51,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 52,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 53,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 54,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 55,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 56,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 57,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 58,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 59,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 60,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 61,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 62,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 63,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 64,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 65,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: null);
        }
    }
}
