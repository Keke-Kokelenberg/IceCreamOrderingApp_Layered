using Repositories.Entities;

namespace Repositories.Repositories;

public interface IOrderRepository
{
    public Task<List<Order>> GetOrdersByUserIdAsync(string userId);
    public Task<Order?> GetOrderByIdAsync(int id);
    public Task AddAsync(Order order);
}