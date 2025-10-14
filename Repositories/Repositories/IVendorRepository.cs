using Repositories.Entities;

namespace Repositories.Repositories;

public interface IVendorRepository
{
    public Task<List<Vendor>> GetAllVendorsAsync();
    public Task<Vendor?> GetVendorByIdAsync(int id);
}