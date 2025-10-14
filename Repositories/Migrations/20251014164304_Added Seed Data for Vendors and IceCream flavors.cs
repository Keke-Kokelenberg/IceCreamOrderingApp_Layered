using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedDataforVendorsandIceCreamflavors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "IceCreamFlavors",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
