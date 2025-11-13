using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddedUserOrderrelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId1",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d988e75-bc95-417a-bf2d-852f84536b67");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fed48273-2fa8-4ec4-9ce7-74e7ba7b08f4");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "85a40638-0355-4b78-9589-4bf7f470da7b", 0, "8e1b2b57-c277-41bb-aeb6-fc15e25e9d54", "user2@test.com", true, false, null, "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAEGghZA0TEapU3HPzV7Qc7ZPxDDduMyrNEAdGB7+AOgJLlMzE08iRap07vKg+xycqGg==", null, false, "952daf7e-6dc8-4cb9-af0c-6aaea06e1d9e", false, "user2@test.com" },
                    { "a9aff0fc-342b-4733-b42a-955581fa4be4", 0, "4c1dfdc4-165c-4f3e-ad24-75e2ec2dc894", "user1@test.com", true, false, null, "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAEKsSvl/ArxKL77re2re/9QcOTu5bEYlqSP85NXvMtqx0p0715Yak+pmtLcl0sM7Mmg==", null, false, "675bf186-4d2b-474b-b497-f39ac8135036", false, "user1@test.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85a40638-0355-4b78-9589-4bf7f470da7b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9aff0fc-342b-4733-b42a-955581fa4be4");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2d988e75-bc95-417a-bf2d-852f84536b67", 0, "ca86c17f-120a-4649-9c86-7753dbfb1a62", "user1@test.com", true, false, null, "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAEErYOadhxw/WGV5C+5oCSEezgWQz7jkgqTLZv5SaCgNInQAl6OA0E1kAfnBhxGL28A==", null, false, "e6fa8bb8-fa40-48ce-8df8-c39cbdfa7b20", false, "user1@test.com" },
                    { "fed48273-2fa8-4ec4-9ce7-74e7ba7b08f4", 0, "e3a91bbb-32e4-4edd-a4f9-a93b96828519", "user2@test.com", true, false, null, "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAECzUqJyTI//fZk5qh4r9FNbuWtcoTY3Ska2SebiCPczVmRJY7js95gKuqs2gt/YrYA==", null, false, "b3bcf240-9817-42b9-af63-d00f7ef3a3bd", false, "user2@test.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId1",
                table: "Orders",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId1",
                table: "Orders",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
