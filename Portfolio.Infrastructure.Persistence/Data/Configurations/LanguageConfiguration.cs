using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Core.Entities;

namespace Portfolio.Infrastructure.Persistence.Data.Configurations
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {

        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("Language");
            builder.HasData(
              new Language { Id = 1, NameEn = "Spanish", NameEs = "Español", CreatedBy = "system", CreatedDate = DateTime.Now },
              new Language { Id = 2, NameEn = "English", NameEs = "Inglés", CreatedBy = "system", CreatedDate = DateTime.Now }
             );
        }
    }
}
