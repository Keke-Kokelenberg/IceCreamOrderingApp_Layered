using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddedOrderandOrderlinesandextraconfigurationstoallEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46dfa17d-7cc3-4604-9b17-1b9e00d9757f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f08a07b9-dc75-4f07-ae2a-97269e83921a");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderLines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    IceCreamId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderLines_IceCreamFlavors_IceCreamId",
                        column: x => x.IceCreamId,
                        principalTable: "IceCreamFlavors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderLines_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "15413034-fd6d-4ec9-8628-18e66f2e5fd9", 0, "6a177b44-4383-4059-8ad6-e486e7e57248", "user1@test.com", true, false, null, "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAEBQWRY7WFKQE9ZnHJ20FC0XRgW9OQrwK6Bm4O/bcvW5+95agpEdF421vvm2jGXpo7w==", null, false, "06177ee5-8a96-4fd1-a577-1335d3c23fb4", false, "user1@test.com" },
                    { "d3b0cb11-232d-43ae-a33e-02b8c2d37d22", 0, "50fa13c8-baeb-4625-b40f-47b03da2d8f0", "user2@test.com", true, false, null, "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAEFhmyxhh0wSosfOSc7r4r3MB5WOg5sNV5ueeIY0ufAYPlC5/G5VWpsBZDW6KEmSNDw==", null, false, "69215c19-73d0-4a12-b6c4-ff19b1f0e057", false, "user2@test.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_IceCreamId",
                table: "OrderLines",
                column: "IceCreamId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_OrderId",
                table: "OrderLines",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId1",
                table: "Orders",
                column: "UserId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderLines");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15413034-fd6d-4ec9-8628-18e66f2e5fd9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d3b0cb11-232d-43ae-a33e-02b8c2d37d22");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "46dfa17d-7cc3-4604-9b17-1b9e00d9757f", 0, "0344ca0a-3358-426e-9a33-1ea86bb99a78", "user2@test.com", true, false, null, "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAEMx1LOfXpQh0PSZIoln7BLNcBtiqMu4nX27cjcZznkzAtpJycuEpdGd0o3l/bLMVPQ==", null, false, "a48cc075-f1dd-45a5-a5f5-38f1313b196a", false, "user2@test.com" },
                    { "f08a07b9-dc75-4f07-ae2a-97269e83921a", 0, "010cb3da-f3ae-4036-b5a8-dd479a824266", "user1@test.com", true, false, null, "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAEHjfRhjudZ58e9l68805Kt2MWgGql+0kpwxgtQ+aeVEXB8+H6PjpHLHc/9rNfASUNw==", null, false, "715e0fa1-26d8-4190-8f47-914f0308db25", false, "user1@test.com" }
                });
        }
    }
}
