using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class CorrectedIDgenerationonOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64118f9c-e311-4aab-8554-5694cf3b40bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a9fd4e8-e423-4317-b7f0-027c52b9597c");

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
                    { "3d63bf60-5c06-477e-bed8-1b7a01e878cb", 0, "08cc6e35-06b7-4d1e-880b-7c952b9b3dbe", "user1@test.com", true, false, null, "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAEL4Kzeab4miXgw/5Y9KYCtE7hyHig4219dw62tbaFGoYPm9GI0W44rwtwYDYIwFoXA==", null, false, "a337cb65-4f37-4482-9754-a9a39fdf9cb1", false, "user1@test.com" },
                    { "b37e622c-5484-4af8-83c0-1e7a75b68320", 0, "54363a81-89a1-4fba-bf0e-c2889ec07891", "user2@test.com", true, false, null, "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAEOUn1WEr1M0cPP76qGgIi6+3cpWCNVdO2NHSDvhDBeK1MoMLA98pN7x3SQMAs9g/WQ==", null, false, "adccb01c-e459-4c85-bc84-c7a02ca6a3f8", false, "user2@test.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d63bf60-5c06-477e-bed8-1b7a01e878cb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b37e622c-5484-4af8-83c0-1e7a75b68320");

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
                    { "64118f9c-e311-4aab-8554-5694cf3b40bd", 0, "38639097-f24e-4ebb-98fe-005a108a68f8", "user2@test.com", true, false, null, "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAELZVGj0eWZFox6dqYlG3JLHadgQrVo32DKYytXxnyfLHqLeJEbbWVufVIwav0N6DiA==", null, false, "8df7e20d-c88f-4194-8f1e-c9f095f917ed", false, "user2@test.com" },
                    { "7a9fd4e8-e423-4317-b7f0-027c52b9597c", 0, "310c4f3d-7260-4dbf-a724-1125396933af", "user1@test.com", true, false, null, "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAEGxzgP3stsGnt+Wjcj5DBA8dUozjCOsVFnYgzW2BGBbif/qjmJU+x3cvywyM27CmuQ==", null, false, "719b7447-7793-4675-9ee5-50f8980aeee7", false, "user1@test.com" }
                });
        }
    }
}
