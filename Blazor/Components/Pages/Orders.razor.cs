using System.Security.Claims;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Repositories.Entities;
using Services;

namespace Blazor.Components.Pages;

public partial class Orders : ComponentBase
{
    [Inject]
    public IOrderService _orderService { get; set; }
    
    [Inject]
    public AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    
    //public ApplicationUser ApplicationUser { get; set; }
    public List<Order> OrdersList { get; set; } = new List<Order>();
    
    private string _message = "Retrieving orders...";
    
    protected override async Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var userId = authState.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (userId == null)
        {
            _message = "Unable to retrieve user ID.";
            return;
        }

        try
        {
            OrdersList = await _orderService.GetOrdersByUserIdAsync(userId);
        }
        catch (Exception e)
        {
            _message = e.Message;
        }

        if (OrdersList.Count == 0)
        {
            _message = "No orders found.";
        }
    }
}