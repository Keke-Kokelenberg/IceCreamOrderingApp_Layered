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
        }
    }
}