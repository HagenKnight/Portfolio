using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Portfolio.Infrastructure.Identity.Configurations;
using Portfolio.Infrastructure.Identity.Models;

namespace Portfolio.Infrastructure.Identity.Data
{
    public class PortfolioIdentityDbContext : IdentityDbContext<ApplicationUser>
    {

        public PortfolioIdentityDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
        }

    }
}
