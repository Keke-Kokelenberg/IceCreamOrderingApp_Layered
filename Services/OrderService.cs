using Repositories.Entities;
using Repositories.Repositories;
using Services.Models;

namespace Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly IVendorService _vendorService;

    public OrderService(IOrderRepository orderRepository, IVendorService vendorService)
    {
        _orderRepository = orderRepository;
        _vendorService = vendorService;
    }

    public async Task<List<Order>> GetOrdersByUserIdAsync(string userId)
    {
        return await _orderRepository.GetOrdersByUserIdAsync(userId);
    }

    public async Task<Order?> GetOrderByIdAsync(int id)
    {
        return await _orderRepository.GetOrderByIdAsync(id);
    }

    public async Task PlaceOrder(string userId, int vendorId, List<OrderLineVM> orderLines)
    {
        //Check if vendor exists & all order lines are valid
        var vendor = await _vendorService.GetVendorByIdAsync(vendorId);
        if (vendor == null)
        {
            throw new Exception($"Vendor with id {vendorId} does not exist.");
        }

        if (orderLines.Count <= 0)
        {
            throw new Exception("No order lines were provided.");
        }

        // All ordered items must be from the same vendor
        foreach (var orderLine in orderLines)
        {
            bool isValid = false;

            foreach (var iceCreamFlavor in vendor.IceCreamFlavors)
            {
                if (orderLine.Id == iceCreamFlavor.Id)
                {
                    isValid = true;
                    break;
                }
            }

            if (isValid is false)
            {
                throw new Exception($"Order line with id {orderLine.Id} does not exist in the vendor's inventory.");
            }
        }

        //Create order & add order lines to order
        Order order = new Order
        {
            UserId = userId,
            VendorId = vendorId,
        };

        foreach (var orderLine in orderLines)
        {
            order.OrderLines.Add(new OrderLine
            {
               OrderId = order.Id,
               IceCreamId = orderLine.Id,
               Quantity = orderLine.Quantity
            });
        }

        //Save order
        await _orderRepository.AddAsync(order);
    }
}