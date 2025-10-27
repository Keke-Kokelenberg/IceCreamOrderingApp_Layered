using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IceCreamFlavors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VendorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IceCreamFlavors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IceCreamFlavors_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VendorId = table.Column<int>(type: "int", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_Orders_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ba7396a8-2b59-457f-a8f8-496eba4151f6", 0, "573ceb19-f6a7-43f6-b9eb-a762c8f956b4", "user2@test.com", true, false, null, "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAENgBaWclvmRinJxmwlgoXxC69gr1YMELtavBH6mH9B30HW3TiyTyBYcN1giuVDNbQQ==", null, false, "b283a047-4c23-4c61-bbcf-5dfe7376f732", false, "user2@test.com" },
                    { "ddb914fd-d9e0-4fb8-84d6-12da4d0233fc", 0, "5a3ca6e8-f6bc-423a-b44f-d4f26c141060", "user1@test.com", true, false, null, "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAECGgx+3FZTOi6zjPj6+wJCQ+Iq9Vr2szpYSXk/bDpKzN8ZX8PzFrBDK/TuEc+6KG6Q==", null, false, "edcc480c-6a2d-4bcc-94b2-4878f6d845cb", false, "user1@test.com" }
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "Id", "Address", "Description", "Email", "ImageUrl", "Name", "PhoneNumber", "Website" },
                values: new object[,]
                {
                    { 1, "123 Frost Street, Cooltown, CT 06510", null, "contact@icecreamparadise.com", null, "Ice Cream Paradise", "555-0123", "www.icecreamparadise.com" },
                    { 2, "456 Scoop Avenue, Freezeville, CT 06511", null, "info@gelatodreams.com", null, "Gelato Dreams", "555-0124", "www.gelatodreams.com" },
                    { 3, "789 Sundae Lane, Chillburg, CT 06512", null, "sales@frostysdelights.com", null, "Frosty's Delights", "555-0125", "www.frostysdelights.com" },
                    { 4, "321 Sugar Street, Sweetville, CT 06513", null, "hello@sweetscoops.com", null, "Sweet Scoops Creamery", "555-0126", "www.sweetscoops.com" },
                    { 5, "567 Cream Avenue, Artville, CT 06514", null, "info@artisanice.com", null, "Artisan Ice Works", "555-0127", "www.artisanice.com" },
                    { 6, "785 Beach Boulevard, Shoreline, CT 06515", null, "info@coastalcreamery.com", null, "Coastal Creamery", "555-0128", "www.coastalcreamery.com" },
                    { 7, "214 Summit Road, Highland, CT 06516", null, "contact@mountainpeakicecream.com", null, "Mountain Peak Ice Cream", "555-0129", "www.mountainpeakicecream.com" },
                    { 8, "433 Downtown Avenue, Cityville, CT 06517", null, "hello@urbanscoop.com", null, "Urban Scoop", "555-0130", "www.urbanscoop.com" },
                    { 9, "928 Milk Street, Farmtown, CT 06518", null, "sales@dairydelight.com", null, "Dairy Delight", "555-0131", "www.dairydelight.com" },
                    { 10, "356 Heritage Lane, Oldtown, CT 06519", null, "parlor@vintageicecream.com", null, "Vintage Ice Cream Parlor", "555-0132", "www.vintageicecream.com" },
                    { 11, "573 Fusion Boulevard, Innovation City, CT 06520", null, "info@fusionfrozen.com", null, "Fusion Frozen Treats", "555-0133", "www.fusionfrozen.com" },
                    { 12, "182 Organic Way, Greenvale, CT 06521", null, "hello@naturesscoop.com", null, "Nature's Scoop", "555-0134", "www.naturesscoop.com" },
                    { 13, "742 Festival Street, Funtown, CT 06522", null, "fun@carnivalcreamery.com", null, "Carnival Creamery", "555-0135", "www.carnivalcreamery.com" },
                    { 14, "105 Campus Drive, College Town, CT 06523", null, "campus@universityscoops.com", null, "University Scoops", "555-0136", "www.universityscoops.com" },
                    { 15, "481 Monument Square, Heritage City, CT 06524", null, "history@historiccreamery.com", null, "Historic Creamery", "555-0137", "www.historiccreamery.com" }
                });

            migrationBuilder.InsertData(
                table: "IceCreamFlavors",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price", "VendorId" },
                values: new object[,]
                {
                    { 1, "Premium vanilla with real bean specks", null, "Vanilla Bean Supreme", 3.99m, 1 },
                    { 2, "Rich chocolate ice cream with fudge swirls", null, "Double Chocolate Fudge", 4.49m, 1 },
                    { 3, "Fresh strawberry ice cream with real fruit pieces", null, "Strawberry Fields", 4.29m, 1 },
                    { 4, "Vanilla ice cream with chocolate cookie pieces", null, "Cookies and Cream", 4.39m, 1 },
                    { 5, "Buttery ice cream with candied pecans", null, "Butter Pecan", 4.59m, 1 },
                    { 6, "Authentic Italian pistachio gelato", null, "Pistachio Perfection", 5.99m, 2 },
                    { 7, "Coffee-flavored gelato with mascarpone swirl", null, "Tiramisu Delight", 5.99m, 2 },
                    { 8, "Cream gelato with fine chocolate shavings", null, "Stracciatella Classic", 5.49m, 2 },
                    { 9, "Smooth vanilla gelato with real bean specks", null, "Vanilla Bean", 5.29m, 2 },
                    { 10, "Rich chocolate gelato with hazelnut paste", null, "Chocolate Hazelnut", 5.79m, 2 },
                    { 11, "Refreshing mint with dark chocolate chips", null, "Mint Chip Madness", 4.79m, 3 },
                    { 12, "Vanilla ice cream loaded with cookie dough chunks", null, "Cookie Dough Blast", 4.99m, 3 },
                    { 13, "Creamy butterscotch with caramel swirls", null, "Butterscotch Ripple", 4.59m, 3 },
                    { 14, "Classic rich chocolate ice cream", null, "Chocolate", 4.29m, 3 },
                    { 15, "Traditional strawberry ice cream with real berries", null, "Strawberry", 4.39m, 3 },
                    { 16, "Caramel ice cream with sea salt and ribbon", null, "Salted Caramel Swirl", 5.29m, 4 },
                    { 17, "Cheesecake ice cream with mixed berry compote", null, "Berry Cheesecake", 5.49m, 4 },
                    { 18, "Maple ice cream with candied pecans", null, "Maple Pecan Crunch", 5.19m, 4 },
                    { 19, "Classic vanilla bean ice cream", null, "Vanilla", 4.89m, 4 },
                    { 20, "Peanut butter ice cream with chocolate cups", null, "Peanut Butter Cup", 5.39m, 4 },
                    { 21, "Delicate lavender ice cream with local honey", null, "Lavender Honey", 6.49m, 5 },
                    { 22, "Dark chocolate ice cream with orange zest", null, "Dark Chocolate Orange", 6.29m, 5 },
                    { 23, "Mascarpone ice cream with roasted figs", null, "Roasted Fig & Mascarpone", 6.99m, 5 },
                    { 24, "Premium artisan chocolate ice cream", null, "Chocolate", 5.99m, 5 },
                    { 25, "Vanilla ice cream infused with cardamom", null, "Cardamom Vanilla", 6.49m, 5 },
                    { 26, "Caramel ice cream with sea salt crystals", null, "Sea Salt Caramel", 5.49m, 6 },
                    { 27, "Creamy coconut ice cream with toasted coconut flakes", null, "Coconut Paradise", 5.29m, 6 },
                    { 28, "Tangy key lime ice cream with graham cracker pieces", null, "Key Lime Pie", 5.69m, 6 },
                    { 29, "Classic vanilla made with beach town charm", null, "Vanilla", 4.99m, 6 },
                    { 30, "Chocolate ice cream with marshmallows, nuts, and fudge", null, "Rocky Mountain Road", 5.79m, 7 },
                    { 31, "Mixed berry ice cream with granola clusters", null, "Wild Berry Trail", 5.49m, 7 },
                    { 32, "Graham cracker ice cream with chocolate and marshmallow", null, "Campfire S'mores", 5.99m, 7 },
                    { 33, "Rich mountain chocolate ice cream", null, "Chocolate", 5.29m, 7 },
                    { 34, "Sophisticated vanilla bean ice cream", null, "City Lights Vanilla", 5.99m, 8 },
                    { 35, "Coffee ice cream with chocolate espresso chips", null, "Espresso Chip", 6.29m, 8 },
                    { 36, "Ultra-rich chocolate ice cream", null, "Brownstone Chocolate", 6.19m, 8 },
                    { 37, "Fresh strawberry ice cream with urban flair", null, "Strawberry", 5.89m, 8 },
                    { 38, "Simple, pure vanilla ice cream", null, "Farm Fresh Vanilla", 4.29m, 9 },
                    { 39, "Old-fashioned chocolate ice cream", null, "Country Chocolate", 4.39m, 9 },
                    { 40, "Butter ice cream with fresh local pecans", null, "Butter Pecan", 4.59m, 9 },
                    { 41, "Classic strawberry made with local berries", null, "Strawberry", 4.49m, 9 },
                    { 42, "Traditional vanilla ice cream with a nostalgic taste", null, "Old-Fashioned Vanilla", 4.99m, 10 },
                    { 43, "Rich chocolate made the old-fashioned way", null, "Classic Chocolate", 4.99m, 10 },
                    { 44, "Strawberry ice cream with soda shop flair", null, "Strawberry Soda Float", 5.29m, 10 },
                    { 45, "Butter ice cream with toffee pieces", null, "Butter Brickle", 5.19m, 10 },
                    { 46, "Japanese matcha ice cream", null, "Matcha Green Tea", 6.49m, 11 },
                    { 47, "Indian-inspired chai tea ice cream", null, "Chai Spice", 6.29m, 11 },
                    { 48, "Thai-inspired mango ice cream with rice pudding swirl", null, "Mango Sticky Rice", 6.99m, 11 },
                    { 49, "Vanilla with global spice blend", null, "Vanilla Fusion", 5.99m, 11 },
                    { 50, "Organic vanilla bean ice cream", null, "Pure Vanilla Bean", 5.99m, 12 },
                    { 51, "Organic mixed berry ice cream", null, "Wild Berry Harvest", 6.29m, 12 },
                    { 52, "Organic fair-trade chocolate ice cream", null, "Dark Chocolate", 6.19m, 12 },
                    { 53, "Organic lavender ice cream with local honey", null, "Honey Lavender", 6.49m, 12 },
                    { 54, "Blue and pink cotton candy flavored ice cream", null, "Cotton Candy", 5.49m, 13 },
                    { 55, "Vanilla ice cream with funnel cake pieces", null, "Funnel Cake", 5.69m, 13 },
                    { 56, "Caramel ice cream with apple pie filling", null, "Caramel Apple", 5.79m, 13 },
                    { 57, "Chocolate and vanilla swirl with cone pieces", null, "Chocolate Dipped Cone", 5.59m, 13 },
                    { 58, "Extra rich chocolate for late-night studying", null, "Study Break Chocolate", 4.99m, 14 },
                    { 59, "Simple, comforting vanilla ice cream", null, "Dorm Room Vanilla", 4.79m, 14 },
                    { 60, "Coffee ice cream with chocolate-covered espresso beans", null, "Final Exam Coffee Crunch", 5.29m, 14 },
                    { 61, "Classic strawberry for college nostalgia", null, "Strawberry", 4.89m, 14 },
                    { 62, "Traditional vanilla made with historic recipe", null, "Heritage Vanilla", 5.49m, 15 },
                    { 63, "Chocolate ice cream from century-old recipe", null, "Founder's Chocolate", 5.49m, 15 },
                    { 64, "Strawberry ice cream with heritage berries", null, "Heirloom Strawberry", 5.69m, 15 },
                    { 65, "Classic butter pecan with family recipe", null, "Antique Butter Pecan", 5.79m, 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_IceCreamFlavors_VendorId",
                table: "IceCreamFlavors",
                column: "VendorId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_VendorId",
                table: "Orders",
                column: "VendorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderLines");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "IceCreamFlavors");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Vendors");
        }
    }
}
