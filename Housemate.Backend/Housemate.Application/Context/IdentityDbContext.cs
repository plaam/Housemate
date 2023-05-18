using Housemate.Application.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Housemate.Application.Context;

public class IdentityDbContext : IdentityDbContext<ApplicationUser>
{
    public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
    {
    }
}