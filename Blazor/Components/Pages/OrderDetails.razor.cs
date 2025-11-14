using Microsoft.AspNetCore.Components;
using Repositories.Entities;
using Services;

namespace Blazor.Components.Pages;

public partial class OrderDetails : ComponentBase
{
    [Inject]
    public IOrderService OrderService { get; set; }
    
    [Parameter]
    public int Id { get; set; }
    
    public Order? Order { get; set; }
    
    private string _message = "Retrieving order details...";
    
    protected override async Task OnParametersSetAsync()
    {
        try
        {
            Order = await OrderService.GetOrderByIdAsync(Id);
        }
        catch (Exception e)
        {
            _message = e.Message;
        }

        if (Order is null)
        {
            _message = $"Order with id {Id} not found.";
        }
    }
}