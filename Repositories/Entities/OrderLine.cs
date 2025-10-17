using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Entities;

public class OrderLine
{
    public int Id { get; set; }
    
    public int OrderId { get; set; }
    public Order Order { get; set; }
    
    public int IceCreamId { get; set; }
    public IceCream IceCream { get; set; }
    
    public int Quantity { get; set; }

    public decimal TotalPrice
    {
        get => IceCream.Price * Quantity;
    }
}

public class OrderLineEntityTypeConfiguration : IEntityTypeConfiguration<OrderLine>
{
    public void Configure(EntityTypeBuilder<OrderLine> builder)
    {
        builder
            .ToTable("OrderLines");
        
        builder
            .HasKey(orderLine => orderLine.Id);
        
        builder
            .Property(orderLine => orderLine.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();
        
        builder
            .HasOne(orderLine => orderLine.Order)
            .WithMany(order => order.OrderLines)
            .HasForeignKey(orderLine => orderLine.OrderId);
        
        builder
            .HasOne(orderLine => orderLine.IceCream)
            .WithMany(iceCream => iceCream.OrderLines)
            .HasForeignKey(orderLine => orderLine.IceCreamId);
        
        builder
            .Ignore(orderLine => orderLine.TotalPrice);
    }
}