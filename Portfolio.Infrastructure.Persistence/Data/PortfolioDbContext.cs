using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Portfolio.Core.Entities;
using Portfolio.Core.Entities.Base;
using Portfolio.Infrastructure.Persistence.Data.Configurations;

namespace Portfolio.Infrastructure.Persistence.Data
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext() : base() { }
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options)
        {

        }

        #region Dbset for Entities

        public DbSet<Country> Countries { get; set; }
        public DbSet<WorkerProfile> WorkerProfiles { get; set; }
        public DbSet<ResumeType> ResumeTypes { get; set; }
        public DbSet<Aptitude> Aptitudes { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<AptitudeOnResume> AptitudesOnResume{ get; set; }
        public DbSet<AptitudeOnProject> AptitudesOnProject{ get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());

            // Singularize table name
            foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
            {
                if (entity.BaseType == null)
                {
                    entity.SetTableName(entity.DisplayName());
                }
            }

            modelBuilder
                .Entity<ResumeType>()
                .HasData(Enum.GetValues(typeof(ResumeTypeEnum))
                .Cast<ResumeTypeEnum>()
                .Select(e => new ResumeType
                {
                    Id = (int)e,
                    Name = e.ToString()
                })
                );
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<EntityBase<int>>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.UtcNow;
                        entry.Entity.CreatedBy = "system";
                        entry.Entity.IsDeleted = false;
                        break;

                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.UtcNow;
                        entry.Entity.LastModifiedBy = "system";
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

    }
}