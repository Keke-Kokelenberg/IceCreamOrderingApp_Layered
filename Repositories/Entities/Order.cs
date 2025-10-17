using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Entities;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    
    public Guid UserId { get; set; }
    public ApplicationUser User { get; set; }
    
    public int VendorId { get; set; }
    public Vendor Vendor { get; set; }
    
    public List<OrderLine> OrderLines { get; set; }
    
    public decimal TotalPrice
    {
        get => OrderLines.Sum(orderLine => orderLine.TotalPrice);
    }
}

public class OrderEntityTypeConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder
            .ToTable("Orders");
        
        builder
            .HasKey(order => order.Id);
        
        builder
            .Property(order => order.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder
            .HasOne(order => order.User);
            // .WithMany(user => user.Orders)
            // .HasForeignKey(order => order.UserId);

        builder
            .HasOne(order => order.Vendor)
            .WithMany(vendor => vendor.Orders)
            .HasForeignKey(order => order.VendorId);

        builder
            .Property(order => order.OrderDate)
            .IsRequired()
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("GETDATE()");
        
        builder
            .Ignore(order => order.TotalPrice);
    }
}