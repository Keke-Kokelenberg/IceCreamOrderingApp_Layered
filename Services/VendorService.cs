using Repositories.Entities;
using Repositories.Repositories;

namespace Services;

public class VendorService: IVendorService
{
    private IVendorRepository _vendorRepository;

    public VendorService(IVendorRepository vendorRepository)
    {
        _vendorRepository = vendorRepository;
    }

    public async Task<List<Vendor>> GetAllVendorsAsync()
    {
        return await _vendorRepository.GetAllVendorsAsync();
    }

    public async Task<Vendor?> GetVendorByIdAsync(int id)
    {
        return await _vendorRepository.GetVendorByIdAsync(id);
    }
}