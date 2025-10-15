using Microsoft.AspNetCore.Components;
using Repositories.Entities;
using Services;

namespace Blazor.Components.Pages;

public partial class Vendors : ComponentBase
{
    [Inject]
    public IVendorService VendorService { get; set; }
    public List<Vendor> VendorList { get; set; } = new List<Vendor>();
    private string _message = "Retrieving vendors...";
    
    protected override async Task OnInitializedAsync()
    {
        VendorList = await VendorService.GetAllVendorsAsync();

        if (VendorList.Count == 0)
        {
            _message = "No vendors found.";       
        }
    }
}