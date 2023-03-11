using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Portfolio.Core.Entities;

//using Portfolio.Infrastructure.Persistence.Data.Configurations;

namespace Portfolio.Infrastructure.Persistence.Data
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext() : base() { }
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options)
        {

        }

        // Dbset for Entities */



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new EntityConfiguration());

            // Singularize table name
            foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
            {
                if (entity.BaseType == null)
                {
                    entity.SetTableName(entity.DisplayName());
                }
            }
        }

    }
}