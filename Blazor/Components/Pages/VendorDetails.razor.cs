using System.Security.Claims;
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

    public Vendor? Vendor;

    private string? _userId;
    
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
    private void PlaceOrder()
    {
        Console.WriteLine("Placing order...");
        if (_userId == null)
        {
            Console.WriteLine("User ID not found.");
            return;
        }
        OrderService.PlaceOrder(_userId, Vendor.Id, _orderLines);
    }
}