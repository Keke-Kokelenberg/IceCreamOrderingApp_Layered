using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Entities;

public class Vendor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public string Address { get; set; }
    public string? PhoneNumber { get; set; }
    public string Email { get; set; }
    public string? Website { get; set; }
    
    public List<Order> Orders { get; set; }
    
    public List<IceCream> IceCreamFlavors { get; set; }
}

public class VendorEntityTypeConfiguration : IEntityTypeConfiguration<Vendor>
{
    public void Configure(EntityTypeBuilder<Vendor> builder)
    {
        builder
            .ToTable("Vendors");
        
        builder
            .HasKey(vendor => vendor.Id);
        
        builder
            .Property(vendor => vendor.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();
        
        builder
            .HasMany(vendor => vendor.Orders)
            .WithOne(order => order.Vendor)
            .HasForeignKey(order => order.VendorId);
        
        builder
            .HasMany(vendor => vendor.IceCreamFlavors)
            .WithOne(iceCream => iceCream.Vendor)
            .HasForeignKey(iceCream => iceCream.VendorId);
    }
}