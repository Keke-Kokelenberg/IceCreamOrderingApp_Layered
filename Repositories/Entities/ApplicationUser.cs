using Microsoft.AspNetCore.Identity;

namespace Repositories.Entities;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public List<Order> Orders { get; set; } = new List<Order>();
}