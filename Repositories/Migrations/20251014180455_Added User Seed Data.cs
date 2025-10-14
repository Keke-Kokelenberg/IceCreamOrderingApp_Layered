using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddedUserSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "fb7dd794-72e7-4c6d-99ab-0a6aa24bc642", "", true, false, null, null, null, "AQAAAAIAAYagAAAAEP8ZEtxj8Ww5t4ZxkXpP5rFG/a272QQRc0KT2m9ruU/5cMNnwyP+d2yhfm8jl70qbg==", null, false, "f56cfcd4-6123-4c8d-b2fb-d7f96433cd78", false, "User1" },
                    { "2", 0, "7a78272b-d6ed-4e09-b152-15cdb0b2f77c", "", true, false, null, null, null, "AQAAAAIAAYagAAAAEFtmMaoleocacW2JtFL8I4WBdopfITqqiGThhauoEBNBE72s4KYbijNZguoFnI6zKg==", null, false, "a8ea4d3b-6d66-4ef9-8696-4a98e06a06a2", false, "User2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");
        }
    }
}
