using Repositories.Entities;

namespace Repositories.Repositories;

public interface IOrderRepository
{
    public Task<List<Order>> GetOrdersByUserIdAsync(string userId);
}