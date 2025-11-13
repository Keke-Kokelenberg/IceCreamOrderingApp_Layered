using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddedOrdersseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85a40638-0355-4b78-9589-4bf7f470da7b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9aff0fc-342b-4733-b42a-955581fa4be4");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0c6acced-767f-442f-8d05-5e5063fd478e", 0, "0689128a-d52b-4421-9af2-f5df6c03ef23", "user1@test.com", true, false, null, "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAECsQBn+tCPOE+fVVVoUHqzvRocLRkNKYnwJlIFoptEcSof2fG7JhoAVO+b0L/Lc55A==", null, false, "4e66d0b5-2d5c-4828-8506-083ac8978435", false, "user1@test.com" },
                    { "151e5d9a-6238-4054-83fc-3cdf5e2a8705", 0, "fc94fe4e-cc76-49cd-bf89-88fffbfd40f3", "user2@test.com", true, false, null, "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAEDYogG5vATAinT2A08zIDhPRmatcyFQG7OxXtGxeX9ghyFgf1UACmvbfNbe2Vtcomg==", null, false, "9e3eb3b3-4b7b-42ee-b940-d1c7be2f8141", false, "user2@test.com" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "UserId", "VendorId" },
                values: new object[,]
                {
                    { 1, "0c6acced-767f-442f-8d05-5e5063fd478e", 1 },
                    { 2, "0c6acced-767f-442f-8d05-5e5063fd478e", 2 }
                });

            migrationBuilder.InsertData(
                table: "OrderLines",
                columns: new[] { "Id", "IceCreamId", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 2 },
                    { 2, 2, 1, 1 },
                    { 3, 4, 1, 3 },
                    { 4, 6, 2, 2 },
                    { 5, 7, 2, 1 },
                    { 6, 10, 2, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "151e5d9a-6238-4054-83fc-3cdf5e2a8705");

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c6acced-767f-442f-8d05-5e5063fd478e");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "85a40638-0355-4b78-9589-4bf7f470da7b", 0, "8e1b2b57-c277-41bb-aeb6-fc15e25e9d54", "user2@test.com", true, false, null, "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAEGghZA0TEapU3HPzV7Qc7ZPxDDduMyrNEAdGB7+AOgJLlMzE08iRap07vKg+xycqGg==", null, false, "952daf7e-6dc8-4cb9-af0c-6aaea06e1d9e", false, "user2@test.com" },
                    { "a9aff0fc-342b-4733-b42a-955581fa4be4", 0, "4c1dfdc4-165c-4f3e-ad24-75e2ec2dc894", "user1@test.com", true, false, null, "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAEKsSvl/ArxKL77re2re/9QcOTu5bEYlqSP85NXvMtqx0p0715Yak+pmtLcl0sM7Mmg==", null, false, "675bf186-4d2b-474b-b497-f39ac8135036", false, "user1@test.com" }
                });
        }
    }
}
