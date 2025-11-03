using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddedVendorDescriptionsintheSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "223c9852-88b2-4f5c-845b-8d61eec95b30");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8260f4a-5c52-4a21-b7da-35ba5a4faba8");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2d988e75-bc95-417a-bf2d-852f84536b67", 0, "ca86c17f-120a-4649-9c86-7753dbfb1a62", "user1@test.com", true, false, null, "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAEErYOadhxw/WGV5C+5oCSEezgWQz7jkgqTLZv5SaCgNInQAl6OA0E1kAfnBhxGL28A==", null, false, "e6fa8bb8-fa40-48ce-8df8-c39cbdfa7b20", false, "user1@test.com" },
                    { "fed48273-2fa8-4ec4-9ce7-74e7ba7b08f4", 0, "e3a91bbb-32e4-4edd-a4f9-a93b96828519", "user2@test.com", true, false, null, "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAECzUqJyTI//fZk5qh4r9FNbuWtcoTY3Ska2SebiCPczVmRJY7js95gKuqs2gt/YrYA==", null, false, "b3bcf240-9817-42b9-af63-d00f7ef3a3bd", false, "user2@test.com" }
                });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "A family-friendly ice cream shop offering classic flavors and creative combinations in a tropical-themed setting.");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Authentic Italian gelato made fresh daily using traditional recipes and the finest imported ingredients.");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "A beloved local ice cream parlor serving premium ice cream with a focus on nostalgic flavors and excellent customer service.");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Handcrafted small-batch ice cream featuring innovative flavor combinations and decadent mix-ins.");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Gourmet ice cream crafted by expert ice cream makers using unique flavor profiles and locally-sourced ingredients.");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Ocean-inspired ice cream shop bringing beachside vibes and refreshing tropical flavors to every scoop.");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Adventure-themed ice cream parlor offering hearty flavors perfect for outdoor enthusiasts and nature lovers.");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Modern ice cream shop with a sophisticated atmosphere, serving premium flavors for the cosmopolitan palate.");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Farm-to-cone ice cream made with fresh dairy from local farms, celebrating simple, wholesome ingredients.");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Step back in time at this old-fashioned soda fountain serving classic ice cream treats in a nostalgic setting.");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Innovative ice cream shop blending international flavors and culinary techniques for a unique taste experience.");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Organic and all-natural ice cream made with sustainably-sourced ingredients and no artificial additives.");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "Fun and festive ice cream shop bringing the excitement of the carnival to every colorful and playful flavor.");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Popular campus hangout serving affordable ice cream favorites and late-night study fuel for students.");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Century-old ice cream institution preserving traditional recipes and serving the community for generations.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d988e75-bc95-417a-bf2d-852f84536b67");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fed48273-2fa8-4ec4-9ce7-74e7ba7b08f4");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "223c9852-88b2-4f5c-845b-8d61eec95b30", 0, "d20366df-4d94-40f1-9949-ca4676c868aa", "user2@test.com", true, false, null, "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAEA3ISDWyCKhRNhlnzUP7B6nurWdyE1Edf4HJ1GMjyD1Y9WhdVt9C8H7RJUzXZqg8NQ==", null, false, "17ce83b5-feab-4c52-9f7b-502ec9ad9968", false, "user2@test.com" },
                    { "b8260f4a-5c52-4a21-b7da-35ba5a4faba8", 0, "1ebe233f-200b-410a-937b-8d5bba248d55", "user1@test.com", true, false, null, "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAEOfgVuDDQlXygCWUsbb/Ayfjm6Up/rxpNzBFZ9Y2RDU+Sfh1xyHpUw4ah8qdoQ8zGA==", null, false, "61170366-973d-421e-96f8-ab11f30a1ee9", false, "user1@test.com" }
                });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: null);
        }
    }
}
