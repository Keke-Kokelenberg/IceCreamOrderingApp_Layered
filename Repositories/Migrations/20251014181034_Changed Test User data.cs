using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class ChangedTestUserdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4c9d7b15-7fc6-4044-bdaf-6e0cb233f26a", "AQAAAAIAAYagAAAAEKAFxRUEuEnIprzJV3SQ+BcWL4MVSHVPJafX3IhoOeb4itzPCzJ6Mn/y/AzSrrZMuw==", "c0a93a84-a1cc-413e-8880-4bd224f232d8", "user1@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d04bcedf-656e-409a-a386-7292f0b83ab7", "AQAAAAIAAYagAAAAEEP/YmRhryQkMzJL1i2YM+rnX/PvgnYbslOOV6usImocJEVVhIDthHMGoIUrd5WB6Q==", "63fb5872-c3a1-4ba8-9102-8c04309be2c7", "user2@test.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fb7dd794-72e7-4c6d-99ab-0a6aa24bc642", "AQAAAAIAAYagAAAAEP8ZEtxj8Ww5t4ZxkXpP5rFG/a272QQRc0KT2m9ruU/5cMNnwyP+d2yhfm8jl70qbg==", "f56cfcd4-6123-4c8d-b2fb-d7f96433cd78", "User1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7a78272b-d6ed-4e09-b152-15cdb0b2f77c", "AQAAAAIAAYagAAAAEFtmMaoleocacW2JtFL8I4WBdopfITqqiGThhauoEBNBE72s4KYbijNZguoFnI6zKg==", "a8ea4d3b-6d66-4ef9-8696-4a98e06a06a2", "User2" });
        }
    }
}
