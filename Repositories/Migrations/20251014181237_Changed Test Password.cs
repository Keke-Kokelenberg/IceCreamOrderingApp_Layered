using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class ChangedTestPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98b2f43a-a3d6-4c62-a493-9f3b2fd375f9", "AQAAAAIAAYagAAAAEJ16bOx5D9gyK3OVIvtTMcIs5/yuVROsx2ggVTpe8ALLZQbo4FcyjtP5qfzd25byhA==", "4f60f177-0ade-4b62-addf-ea9e2ab61df7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8316ac3a-9ba5-4e2b-8a41-f61a13efad07", "AQAAAAIAAYagAAAAEJ85ZMvjlYPPdpWU2RpJu11MHxmQDYQxY6AVoB8d1+fs/nkX14dXTYvXlIQV/vbIoA==", "3c242e31-ea9b-40f4-a20b-eb197305251a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c9d7b15-7fc6-4044-bdaf-6e0cb233f26a", "AQAAAAIAAYagAAAAEKAFxRUEuEnIprzJV3SQ+BcWL4MVSHVPJafX3IhoOeb4itzPCzJ6Mn/y/AzSrrZMuw==", "c0a93a84-a1cc-413e-8880-4bd224f232d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d04bcedf-656e-409a-a386-7292f0b83ab7", "AQAAAAIAAYagAAAAEEP/YmRhryQkMzJL1i2YM+rnX/PvgnYbslOOV6usImocJEVVhIDthHMGoIUrd5WB6Q==", "63fb5872-c3a1-4ba8-9102-8c04309be2c7" });
        }
    }
}
