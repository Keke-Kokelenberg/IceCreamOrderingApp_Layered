using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddedexplicitEntityrelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42529bf2-e359-41c7-8bb1-4332c853c750");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ad6fdae-8d0b-4150-a47d-c56007182b28");

            migrationBuilder.AddColumn<int>(
                name: "VendorId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "64118f9c-e311-4aab-8554-5694cf3b40bd", 0, "38639097-f24e-4ebb-98fe-005a108a68f8", "user2@test.com", true, false, null, "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAELZVGj0eWZFox6dqYlG3JLHadgQrVo32DKYytXxnyfLHqLeJEbbWVufVIwav0N6DiA==", null, false, "8df7e20d-c88f-4194-8f1e-c9f095f917ed", false, "user2@test.com" },
                    { "7a9fd4e8-e423-4317-b7f0-027c52b9597c", 0, "310c4f3d-7260-4dbf-a724-1125396933af", "user1@test.com", true, false, null, "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAEGxzgP3stsGnt+Wjcj5DBA8dUozjCOsVFnYgzW2BGBbif/qjmJU+x3cvywyM27CmuQ==", null, false, "719b7447-7793-4675-9ee5-50f8980aeee7", false, "user1@test.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_VendorId",
                table: "Orders",
                column: "VendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Vendors_VendorId",
                table: "Orders",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Vendors_VendorId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_VendorId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64118f9c-e311-4aab-8554-5694cf3b40bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a9fd4e8-e423-4317-b7f0-027c52b9597c");

            migrationBuilder.DropColumn(
                name: "VendorId",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "42529bf2-e359-41c7-8bb1-4332c853c750", 0, "8387ee9f-0767-4f6b-8e45-e35829bb48a0", "user2@test.com", true, false, null, "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAEOo/FntJOek2lK6BY2HSXwdrMI68qxeLEaPaMBn04MPSPNcNwuBcnd8T2HymmfRAEw==", null, false, "c293ecbe-ac3a-4bc8-9770-ad11cbda6b77", false, "user2@test.com" },
                    { "7ad6fdae-8d0b-4150-a47d-c56007182b28", 0, "a6acd87a-effa-4861-906a-3ee9e8ad2de2", "user1@test.com", true, false, null, "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAECGEqtgYnR/vGLvOr2hPgVNkGySxYD1/J3EDUFYOkB12JvT4rSzLUCZm0+EWXqDJrw==", null, false, "3a2b42a8-20b3-4a5a-9b78-fc78bd72abdc", false, "user1@test.com" }
                });
        }
    }
}
