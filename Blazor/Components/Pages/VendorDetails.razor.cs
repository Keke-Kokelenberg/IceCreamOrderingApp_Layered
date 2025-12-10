using Blazor.Models;
using Microsoft.AspNetCore.Components;
using Repositories.Entities;
using Services;

namespace Blazor.Components.Pages;

public partial class VendorDetails : ComponentBase
{
    [Parameter]
    public int Id { get; set; }
    
    [Inject]
    public IVendorService VendorService { get; set; }

    public Vendor? Vendor;
    
    private string _message = "Retrieving vendor details...";
    
    private List<OrderLineVM> _orderLines = new List<OrderLineVM>();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Vendor = await VendorService.GetVendorByIdAsync(Id);
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
}