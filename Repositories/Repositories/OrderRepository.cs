using Microsoft.EntityFrameworkCore;
using Repositories.Context;
using Repositories.Entities;

namespace Repositories.Repositories;

public class OrderRepository: IOrderRepository
{
    private readonly ApplicationDbContext _context;

    public OrderRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Order>> GetOrdersByUserIdAsync(string userId)
    {
        return await _context.Orders
            .Where(o => o.UserId == userId)
            .ToListAsync();
    }
}