using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Entities;

public class IceCream
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string? ImageUrl { get; set; }
    public decimal Price { get; set; }
    
    public int VendorId { get; set; }
    public Vendor Vendor { get; set; }
    
    public List<OrderLine> OrderLines { get; set; }
}

public class IceCreamEntityTypeConfiguration : IEntityTypeConfiguration<IceCream>
{
    public void Configure(EntityTypeBuilder<IceCream> builder)
    {
        builder
            .ToTable("IceCreamFlavors");
        
        builder
            .HasKey(iceCream => iceCream.Id);
        
        builder
            .Property(iceCream => iceCream.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();
        
        builder
            .HasOne(iceCream => iceCream.Vendor)
            .WithMany(vendor => vendor.IceCreamFlavors)
            .HasForeignKey(iceCream => iceCream.VendorId);
        
        builder
            .HasMany(iceCream => iceCream.OrderLines)
            .WithOne(orderLine => orderLine.IceCream)
            .HasForeignKey(orderLine => orderLine.IceCreamId);
    }
}