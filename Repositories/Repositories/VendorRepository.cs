using Microsoft.EntityFrameworkCore;
using Repositories.Context;
using Repositories.Entities;

namespace Repositories.Repositories;

public class VendorRepository: IVendorRepository
{
    private readonly ApplicationDbContext _context;

    public VendorRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Vendor>> GetAllVendorsAsync()
    {
        return await _context.Vendors
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Vendor?> GetVendorByIdAsync(int id)
    {
        return await _context.Vendors
            .Include(vendor => vendor.IceCreamFlavors)
            .FirstOrDefaultAsync(vendor => vendor.Id == id);
    }
}