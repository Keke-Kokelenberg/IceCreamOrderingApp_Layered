using Repositories.Entities;

namespace Services;

public interface IVendorService
{
    public Task<List<Vendor>> GetAllVendorsAsync();
    public Task<Vendor?> GetVendorByIdAsync(int id);
}