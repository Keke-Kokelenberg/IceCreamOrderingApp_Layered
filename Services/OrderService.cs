using Repositories.Entities;
using Repositories.Repositories;

namespace Services;

public class OrderService: IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<List<Order>> GetOrdersByUserIdAsync(string userId)
    {
        return await _orderRepository.GetOrdersByUserIdAsync(userId);
    }
}