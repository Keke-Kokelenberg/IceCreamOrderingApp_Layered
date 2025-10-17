using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class ChangedUserIdtoGuid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15413034-fd6d-4ec9-8628-18e66f2e5fd9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d3b0cb11-232d-43ae-a33e-02b8c2d37d22");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "42529bf2-e359-41c7-8bb1-4332c853c750", 0, "8387ee9f-0767-4f6b-8e45-e35829bb48a0", "user2@test.com", true, false, null, "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAEOo/FntJOek2lK6BY2HSXwdrMI68qxeLEaPaMBn04MPSPNcNwuBcnd8T2HymmfRAEw==", null, false, "c293ecbe-ac3a-4bc8-9770-ad11cbda6b77", false, "user2@test.com" },
                    { "7ad6fdae-8d0b-4150-a47d-c56007182b28", 0, "a6acd87a-effa-4861-906a-3ee9e8ad2de2", "user1@test.com", true, false, null, "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAECGEqtgYnR/vGLvOr2hPgVNkGySxYD1/J3EDUFYOkB12JvT4rSzLUCZm0+EWXqDJrw==", null, false, "3a2b42a8-20b3-4a5a-9b78-fc78bd72abdc", false, "user1@test.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42529bf2-e359-41c7-8bb1-4332c853c750");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ad6fdae-8d0b-4150-a47d-c56007182b28");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEWID()")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "15413034-fd6d-4ec9-8628-18e66f2e5fd9", 0, "6a177b44-4383-4059-8ad6-e486e7e57248", "user1@test.com", true, false, null, "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAEBQWRY7WFKQE9ZnHJ20FC0XRgW9OQrwK6Bm4O/bcvW5+95agpEdF421vvm2jGXpo7w==", null, false, "06177ee5-8a96-4fd1-a577-1335d3c23fb4", false, "user1@test.com" },
                    { "d3b0cb11-232d-43ae-a33e-02b8c2d37d22", 0, "50fa13c8-baeb-4625-b40f-47b03da2d8f0", "user2@test.com", true, false, null, "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAEFhmyxhh0wSosfOSc7r4r3MB5WOg5sNV5ueeIY0ufAYPlC5/G5VWpsBZDW6KEmSNDw==", null, false, "69215c19-73d0-4a12-b6c4-ff19b1f0e057", false, "user2@test.com" }
                });
        }
    }
}
