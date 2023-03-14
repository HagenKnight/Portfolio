﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Portfolio.Core.Entities;
using Portfolio.Infrastructure.Persistence.Data.Configurations;

namespace Portfolio.Infrastructure.Persistence.Data
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext() : base() { }
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options)
        {

        }

        // Dbset for Entities */
        public DbSet<Country> Countries { get; set; }
        public DbSet<ResumeType> ResumeTypes { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Certificate> Certificates { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CountryConfiguration());

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

    }
}