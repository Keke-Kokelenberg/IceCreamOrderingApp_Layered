using Repositories.Entities;

namespace Services;

public interface IOrderService
{
    public Task<List<Order>> GetOrdersByUserIdAsync(string userId);
    public Task<Order?> GetOrderByIdAsync(int id);
}