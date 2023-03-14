using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Identity;
using Portfolio.Infrastructure.Identity.Configurations;

namespace Portfolio.Infrastructure.Identity
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
