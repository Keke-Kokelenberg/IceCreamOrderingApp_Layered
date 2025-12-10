namespace Blazor.Models;

public class OrderLineVM
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    
    public OrderLineVM(int id, decimal price)
    {
        Id = id;
        Price = price;
        Quantity = 0;
    }
    
    public decimal TotalPrice => Price * Quantity;
}