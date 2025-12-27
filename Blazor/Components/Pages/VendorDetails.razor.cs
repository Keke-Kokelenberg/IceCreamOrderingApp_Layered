using System.Security.Claims;
using Blazor.Components.Account.Pages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Repositories.Entities;
using Services;
using Services.Models;

namespace Blazor.Components.Pages;

public partial class VendorDetails : ComponentBase
{
    [Parameter]
    public int Id { get; set; }
    
    [Inject]
    public IVendorService VendorService { get; set; }
    
    [Inject]
    public IOrderService OrderService { get; set; }
    
    [Inject]
    public AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    
    [Inject]
    public NavigationManager NavigationManager { get; set; }

    public Vendor? Vendor;

    private string? _userId;

    private bool _somethingWentWrong = false;
    
    private string _message = "Retrieving vendor details...";
    
    private List<OrderLineVM> _orderLines = new List<OrderLineVM>();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Vendor = await VendorService.GetVendorByIdAsync(Id);
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            _userId = authState.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
        catch (Exception e)
        {
            _message = e.Message;      
        }
        if (Vendor == null)
        {
            _message = $"Vendor with id {Id} not found.";
            return;
        }
        
        foreach (var iceCreamFlavor in Vendor.IceCreamFlavors)
        {
            _orderLines.Add(new OrderLineVM(iceCreamFlavor.Id, iceCreamFlavor.Price));
        }
    }

    private void DecreaseOrderAmount(int index)
    {
        _orderLines[index].Quantity--;
        if (_orderLines[index].Quantity < 0)
        {
            _orderLines[index].Quantity = 0;
        }
    }

    private void IncreaseOrderAmount(int index)
    {
        _orderLines[index].Quantity++;
    }
    
    [Authorize]
    private async Task PlaceOrder()
    {
        // Sanity check if user is logged in
        if (_userId == null)
        {
            _somethingWentWrong = true;
            _message = "You must be logged in to place an order.";
            return;
        }
        
        // Remove empty order lines
        var orderLines = _orderLines.Where(orderLine => orderLine.Quantity > 0).ToList();
        if (orderLines.Count == 0)
        {
            _somethingWentWrong = true;
            _message = "You must order at least one item.";
            return;
        }
        
        // Place order
        await OrderService.PlaceOrder(_userId, Vendor.Id, orderLines);
        
        // Redirect to orders page
        NavigationManager.NavigateTo("/Orders");
    }

    private void GoToLogin()
    {
        NavigationManager.NavigateTo("Account/Login", true);
    }
}