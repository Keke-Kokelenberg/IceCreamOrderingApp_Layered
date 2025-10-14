using System.Reflection;
using Azure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Repositories.Entities;

namespace Repositories.Context;

public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
{
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<Vendor> Vendors { get; set; }
    public DbSet<IceCream> IceCreamFlavors { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        //
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        
        SeedData(builder);
    }

    private void SeedData(ModelBuilder modelBuilder)
    {
        //ApplicationUsers
        const string password = "Test";
        var passwordHasher = new PasswordHasher<ApplicationUser>();
        
        var user1 = new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            UserName = "user1@test.com",
            NormalizedUserName = "user1@test.com".ToUpper(),
            Email = "user1@test.com",
            NormalizedEmail = "user1@test.com".ToUpper(),
            EmailConfirmed = true,
        };
        user1.PasswordHash = passwordHasher.HashPassword(user1, password);
        
        var user2 = new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            UserName = "user2@test.com",
            NormalizedUserName = "user2@test.com".ToUpper(),
            Email = "user2@test.com",
            NormalizedEmail = "user2@test.com".ToUpper(),
            EmailConfirmed = true,
        };
        user2.PasswordHash = passwordHasher.HashPassword(user2, password);
        
        modelBuilder
            .Entity<ApplicationUser>()
            .HasData(user1, user2);
        
        // Vendors
        modelBuilder
            .Entity<Vendor>()
            .HasData(
                new Vendor
                {
                    Id = 1,
                    Name = "Ice Cream Paradise",
                    Address = "123 Frost Street, Cooltown, CT 06510",
                    Website = "www.icecreamparadise.com",
                    PhoneNumber = "555-0123",
                    Email = "contact@icecreamparadise.com"
                },
                new Vendor
                {
                    Id = 2,
                    Name = "Gelato Dreams",
                    Address = "456 Scoop Avenue, Freezeville, CT 06511",
                    Website = "www.gelatodreams.com",
                    PhoneNumber = "555-0124",
                    Email = "info@gelatodreams.com"
                },
                new Vendor
                {
                    Id = 3,
                    Name = "Frosty's Delights",
                    Address = "789 Sundae Lane, Chillburg, CT 06512",
                    Website = "www.frostysdelights.com",
                    PhoneNumber = "555-0125",
                    Email = "sales@frostysdelights.com"
                },
                new Vendor
                {
                    Id = 4,
                    Name = "Sweet Scoops Creamery",
                    Address = "321 Sugar Street, Sweetville, CT 06513",
                    Website = "www.sweetscoops.com",
                    PhoneNumber = "555-0126",
                    Email = "hello@sweetscoops.com"
                },
                new Vendor
                {
                    Id = 5,
                    Name = "Artisan Ice Works",
                    Address = "567 Cream Avenue, Artville, CT 06514",
                    Website = "www.artisanice.com",
                    PhoneNumber = "555-0127",
                    Email = "info@artisanice.com"
                },
                new Vendor
                {
                    Id = 6,
                    Name = "Coastal Creamery",
                    Address = "785 Beach Boulevard, Shoreline, CT 06515",
                    Website = "www.coastalcreamery.com",
                    PhoneNumber = "555-0128",
                    Email = "info@coastalcreamery.com"
                },
                new Vendor
                {
                    Id = 7,
                    Name = "Mountain Peak Ice Cream",
                    Address = "214 Summit Road, Highland, CT 06516",
                    Website = "www.mountainpeakicecream.com",
                    PhoneNumber = "555-0129",
                    Email = "contact@mountainpeakicecream.com"
                },
                new Vendor
                {
                    Id = 8,
                    Name = "Urban Scoop",
                    Address = "433 Downtown Avenue, Cityville, CT 06517",
                    Website = "www.urbanscoop.com",
                    PhoneNumber = "555-0130",
                    Email = "hello@urbanscoop.com"
                },
                new Vendor
                {
                    Id = 9,
                    Name = "Dairy Delight",
                    Address = "928 Milk Street, Farmtown, CT 06518",
                    Website = "www.dairydelight.com",
                    PhoneNumber = "555-0131",
                    Email = "sales@dairydelight.com"
                },
                new Vendor
                {
                    Id = 10,
                    Name = "Vintage Ice Cream Parlor",
                    Address = "356 Heritage Lane, Oldtown, CT 06519",
                    Website = "www.vintageicecream.com",
                    PhoneNumber = "555-0132",
                    Email = "parlor@vintageicecream.com"
                },
                new Vendor
                {
                    Id = 11,
                    Name = "Fusion Frozen Treats",
                    Address = "573 Fusion Boulevard, Innovation City, CT 06520",
                    Website = "www.fusionfrozen.com",
                    PhoneNumber = "555-0133",
                    Email = "info@fusionfrozen.com"
                },
                new Vendor
                {
                    Id = 12,
                    Name = "Nature's Scoop",
                    Address = "182 Organic Way, Greenvale, CT 06521",
                    Website = "www.naturesscoop.com",
                    PhoneNumber = "555-0134",
                    Email = "hello@naturesscoop.com"
                },
                new Vendor
                {
                    Id = 13,
                    Name = "Carnival Creamery",
                    Address = "742 Festival Street, Funtown, CT 06522",
                    Website = "www.carnivalcreamery.com",
                    PhoneNumber = "555-0135",
                    Email = "fun@carnivalcreamery.com"
                },
                new Vendor
                {
                    Id = 14,
                    Name = "University Scoops",
                    Address = "105 Campus Drive, College Town, CT 06523",
                    Website = "www.universityscoops.com",
                    PhoneNumber = "555-0136",
                    Email = "campus@universityscoops.com"
                },
                new Vendor
                {
                    Id = 15,
                    Name = "Historic Creamery",
                    Address = "481 Monument Square, Heritage City, CT 06524",
                    Website = "www.historiccreamery.com",
                    PhoneNumber = "555-0137",
                    Email = "history@historiccreamery.com"
                }
            );

        // IceCream Flavors
        modelBuilder
            .Entity<IceCream>()
            .HasData(
                // Ice Cream Paradise flavors
                new IceCream
                {
                    Id = 1, Name = "Vanilla Bean Supreme", Description = "Premium vanilla with real bean specks",
                    Price = 3.99m, VendorId = 1
                },
                new IceCream
                {
                    Id = 2, Name = "Double Chocolate Fudge", Description = "Rich chocolate ice cream with fudge swirls",
                    Price = 4.49m, VendorId = 1
                },
                new IceCream
                {
                    Id = 3, Name = "Strawberry Fields",
                    Description = "Fresh strawberry ice cream with real fruit pieces", Price = 4.29m, VendorId = 1
                },
                new IceCream
                {
                    Id = 4, Name = "Cookies and Cream", Description = "Vanilla ice cream with chocolate cookie pieces",
                    Price = 4.39m, VendorId = 1
                },
                new IceCream
                {
                    Id = 5, Name = "Butter Pecan", Description = "Buttery ice cream with candied pecans",
                    Price = 4.59m, VendorId = 1
                },

                // Gelato Dreams flavors
                new IceCream
                {
                    Id = 6, Name = "Pistachio Perfection", Description = "Authentic Italian pistachio gelato",
                    Price = 5.99m, VendorId = 2
                },
                new IceCream
                {
                    Id = 7, Name = "Tiramisu Delight", Description = "Coffee-flavored gelato with mascarpone swirl",
                    Price = 5.99m, VendorId = 2
                },
                new IceCream
                {
                    Id = 8, Name = "Stracciatella Classic", Description = "Cream gelato with fine chocolate shavings",
                    Price = 5.49m, VendorId = 2
                },
                new IceCream
                {
                    Id = 9, Name = "Vanilla Bean", Description = "Smooth vanilla gelato with real bean specks",
                    Price = 5.29m, VendorId = 2
                },
                new IceCream
                {
                    Id = 10, Name = "Chocolate Hazelnut", Description = "Rich chocolate gelato with hazelnut paste",
                    Price = 5.79m, VendorId = 2
                },

                // Frosty's Delights flavors
                new IceCream
                {
                    Id = 11, Name = "Mint Chip Madness", Description = "Refreshing mint with dark chocolate chips",
                    Price = 4.79m, VendorId = 3
                },
                new IceCream
                {
                    Id = 12, Name = "Cookie Dough Blast",
                    Description = "Vanilla ice cream loaded with cookie dough chunks", Price = 4.99m, VendorId = 3
                },
                new IceCream
                {
                    Id = 13, Name = "Butterscotch Ripple", Description = "Creamy butterscotch with caramel swirls",
                    Price = 4.59m, VendorId = 3
                },
                new IceCream
                {
                    Id = 14, Name = "Chocolate", Description = "Classic rich chocolate ice cream",
                    Price = 4.29m, VendorId = 3
                },
                new IceCream
                {
                    Id = 15, Name = "Strawberry", Description = "Traditional strawberry ice cream with real berries",
                    Price = 4.39m, VendorId = 3
                },

                // Sweet Scoops Creamery flavors
                new IceCream
                {
                    Id = 16, Name = "Salted Caramel Swirl", Description = "Caramel ice cream with sea salt and ribbon",
                    Price = 5.29m, VendorId = 4
                },
                new IceCream
                {
                    Id = 17, Name = "Berry Cheesecake", Description = "Cheesecake ice cream with mixed berry compote",
                    Price = 5.49m, VendorId = 4
                },
                new IceCream
                {
                    Id = 18, Name = "Maple Pecan Crunch", Description = "Maple ice cream with candied pecans",
                    Price = 5.19m, VendorId = 4
                },
                new IceCream
                {
                    Id = 19, Name = "Vanilla", Description = "Classic vanilla bean ice cream",
                    Price = 4.89m, VendorId = 4
                },
                new IceCream
                {
                    Id = 20, Name = "Peanut Butter Cup", Description = "Peanut butter ice cream with chocolate cups",
                    Price = 5.39m, VendorId = 4
                },

                // Artisan Ice Works flavors
                new IceCream
                {
                    Id = 21, Name = "Lavender Honey", Description = "Delicate lavender ice cream with local honey",
                    Price = 6.49m, VendorId = 5
                },
                new IceCream
                {
                    Id = 22, Name = "Dark Chocolate Orange", Description = "Dark chocolate ice cream with orange zest",
                    Price = 6.29m, VendorId = 5
                },
                new IceCream
                {
                    Id = 23, Name = "Roasted Fig & Mascarpone", Description = "Mascarpone ice cream with roasted figs",
                    Price = 6.99m, VendorId = 5
                },
                new IceCream
                {
                    Id = 24, Name = "Chocolate", Description = "Premium artisan chocolate ice cream",
                    Price = 5.99m, VendorId = 5
                },
                new IceCream
                {
                    Id = 25, Name = "Cardamom Vanilla", Description = "Vanilla ice cream infused with cardamom",
                    Price = 6.49m, VendorId = 5
                },

                // Coastal Creamery flavors
                new IceCream
                {
                    Id = 26, Name = "Sea Salt Caramel", Description = "Caramel ice cream with sea salt crystals",
                    Price = 5.49m, VendorId = 6
                },
                new IceCream
                {
                    Id = 27, Name = "Coconut Paradise",
                    Description = "Creamy coconut ice cream with toasted coconut flakes",
                    Price = 5.29m, VendorId = 6
                },
                new IceCream
                {
                    Id = 28, Name = "Key Lime Pie", Description = "Tangy key lime ice cream with graham cracker pieces",
                    Price = 5.69m, VendorId = 6
                },
                new IceCream
                {
                    Id = 29, Name = "Vanilla", Description = "Classic vanilla made with beach town charm",
                    Price = 4.99m, VendorId = 6
                },

                // Mountain Peak Ice Cream flavors
                new IceCream
                {
                    Id = 30, Name = "Rocky Mountain Road",
                    Description = "Chocolate ice cream with marshmallows, nuts, and fudge",
                    Price = 5.79m, VendorId = 7
                },
                new IceCream
                {
                    Id = 31, Name = "Wild Berry Trail", Description = "Mixed berry ice cream with granola clusters",
                    Price = 5.49m, VendorId = 7
                },
                new IceCream
                {
                    Id = 32, Name = "Campfire S'mores",
                    Description = "Graham cracker ice cream with chocolate and marshmallow",
                    Price = 5.99m, VendorId = 7
                },
                new IceCream
                {
                    Id = 33, Name = "Chocolate", Description = "Rich mountain chocolate ice cream",
                    Price = 5.29m, VendorId = 7
                },

                // Urban Scoop flavors
                new IceCream
                {
                    Id = 34, Name = "City Lights Vanilla", Description = "Sophisticated vanilla bean ice cream",
                    Price = 5.99m, VendorId = 8
                },
                new IceCream
                {
                    Id = 35, Name = "Espresso Chip", Description = "Coffee ice cream with chocolate espresso chips",
                    Price = 6.29m, VendorId = 8
                },
                new IceCream
                {
                    Id = 36, Name = "Brownstone Chocolate", Description = "Ultra-rich chocolate ice cream",
                    Price = 6.19m, VendorId = 8
                },
                new IceCream
                {
                    Id = 37, Name = "Strawberry", Description = "Fresh strawberry ice cream with urban flair",
                    Price = 5.89m, VendorId = 8
                },

                // Dairy Delight flavors
                new IceCream
                {
                    Id = 38, Name = "Farm Fresh Vanilla", Description = "Simple, pure vanilla ice cream",
                    Price = 4.29m, VendorId = 9
                },
                new IceCream
                {
                    Id = 39, Name = "Country Chocolate", Description = "Old-fashioned chocolate ice cream",
                    Price = 4.39m, VendorId = 9
                },
                new IceCream
                {
                    Id = 40, Name = "Butter Pecan", Description = "Butter ice cream with fresh local pecans",
                    Price = 4.59m, VendorId = 9
                },
                new IceCream
                {
                    Id = 41, Name = "Strawberry", Description = "Classic strawberry made with local berries",
                    Price = 4.49m, VendorId = 9
                },

                // Vintage Ice Cream Parlor flavors
                new IceCream
                {
                    Id = 42, Name = "Old-Fashioned Vanilla",
                    Description = "Traditional vanilla ice cream with a nostalgic taste",
                    Price = 4.99m, VendorId = 10
                },
                new IceCream
                {
                    Id = 43, Name = "Classic Chocolate", Description = "Rich chocolate made the old-fashioned way",
                    Price = 4.99m, VendorId = 10
                },
                new IceCream
                {
                    Id = 44, Name = "Strawberry Soda Float", Description = "Strawberry ice cream with soda shop flair",
                    Price = 5.29m, VendorId = 10
                },
                new IceCream
                {
                    Id = 45, Name = "Butter Brickle", Description = "Butter ice cream with toffee pieces",
                    Price = 5.19m, VendorId = 10
                },

                // Fusion Frozen Treats flavors
                new IceCream
                {
                    Id = 46, Name = "Matcha Green Tea", Description = "Japanese matcha ice cream",
                    Price = 6.49m, VendorId = 11
                },
                new IceCream
                {
                    Id = 47, Name = "Chai Spice", Description = "Indian-inspired chai tea ice cream",
                    Price = 6.29m, VendorId = 11
                },
                new IceCream
                {
                    Id = 48, Name = "Mango Sticky Rice",
                    Description = "Thai-inspired mango ice cream with rice pudding swirl",
                    Price = 6.99m, VendorId = 11
                },
                new IceCream
                {
                    Id = 49, Name = "Vanilla Fusion", Description = "Vanilla with global spice blend",
                    Price = 5.99m, VendorId = 11
                },

                // Nature's Scoop flavors
                new IceCream
                {
                    Id = 50, Name = "Pure Vanilla Bean", Description = "Organic vanilla bean ice cream",
                    Price = 5.99m, VendorId = 12
                },
                new IceCream
                {
                    Id = 51, Name = "Wild Berry Harvest", Description = "Organic mixed berry ice cream",
                    Price = 6.29m, VendorId = 12
                },
                new IceCream
                {
                    Id = 52, Name = "Dark Chocolate", Description = "Organic fair-trade chocolate ice cream",
                    Price = 6.19m, VendorId = 12
                },
                new IceCream
                {
                    Id = 53, Name = "Honey Lavender", Description = "Organic lavender ice cream with local honey",
                    Price = 6.49m, VendorId = 12
                },

                // Carnival Creamery flavors
                new IceCream
                {
                    Id = 54, Name = "Cotton Candy", Description = "Blue and pink cotton candy flavored ice cream",
                    Price = 5.49m, VendorId = 13
                },
                new IceCream
                {
                    Id = 55, Name = "Funnel Cake", Description = "Vanilla ice cream with funnel cake pieces",
                    Price = 5.69m, VendorId = 13
                },
                new IceCream
                {
                    Id = 56, Name = "Caramel Apple", Description = "Caramel ice cream with apple pie filling",
                    Price = 5.79m, VendorId = 13
                },
                new IceCream
                {
                    Id = 57, Name = "Chocolate Dipped Cone",
                    Description = "Chocolate and vanilla swirl with cone pieces",
                    Price = 5.59m, VendorId = 13
                },

                // University Scoops flavors
                new IceCream
                {
                    Id = 58, Name = "Study Break Chocolate",
                    Description = "Extra rich chocolate for late-night studying",
                    Price = 4.99m, VendorId = 14
                },
                new IceCream
                {
                    Id = 59, Name = "Dorm Room Vanilla", Description = "Simple, comforting vanilla ice cream",
                    Price = 4.79m, VendorId = 14
                },
                new IceCream
                {
                    Id = 60, Name = "Final Exam Coffee Crunch",
                    Description = "Coffee ice cream with chocolate-covered espresso beans",
                    Price = 5.29m, VendorId = 14
                },
                new IceCream
                {
                    Id = 61, Name = "Strawberry", Description = "Classic strawberry for college nostalgia",
                    Price = 4.89m, VendorId = 14
                },

                // Historic Creamery flavors
                new IceCream
                {
                    Id = 62, Name = "Heritage Vanilla", Description = "Traditional vanilla made with historic recipe",
                    Price = 5.49m, VendorId = 15
                },
                new IceCream
                {
                    Id = 63, Name = "Founder's Chocolate", Description = "Chocolate ice cream from century-old recipe",
                    Price = 5.49m, VendorId = 15
                },
                new IceCream
                {
                    Id = 64, Name = "Heirloom Strawberry", Description = "Strawberry ice cream with heritage berries",
                    Price = 5.69m, VendorId = 15
                },
                new IceCream
                {
                    Id = 65, Name = "Antique Butter Pecan", Description = "Classic butter pecan with family recipe",
                    Price = 5.79m, VendorId = 15
                }
            );
        
    }
}