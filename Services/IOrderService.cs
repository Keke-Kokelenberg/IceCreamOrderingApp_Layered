using Repositories.Entities;
using Services.Models;

namespace Services;

public interface IOrderService
{
    public Task<List<Order>> GetOrdersByUserIdAsync(string userId);
    public Task<Order?> GetOrderByIdAsync(int id);
    public Task PlaceOrder(string userId, int vendorId, List<OrderLineVM> orderLines);
}