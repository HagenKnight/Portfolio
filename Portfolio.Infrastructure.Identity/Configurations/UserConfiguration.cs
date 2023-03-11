using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Infrastructure.Identity.Models;

namespace Portfolio.Infrastructure.Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "a62397d8-ce0d-4dfe-a2ff-684f581b2488",
                    Email = "giovannigarcia.de@gmail.com",
                    NormalizedEmail = "giovannigarcia.de@gmail.com",
                    FirstName = "Giovanni",
                    Lastname = "García",
                    UserName = "giovannigarcia.de@gmail.com",
                    NormalizedUserName = "giovannigarcia.de@gmail.com",
                    PasswordHash = hasher.HashPassword(null, "V0yager21$"),
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    Id = "d10fb303-28e4-4e13-a678-7dc5f3a134ad",
                    Email = "lordhagen.de@gmail.com",
                    NormalizedEmail = "lordhagen.de@gmail.com",
                    FirstName = "Hagen",
                    Lastname = "von Merak",
                    UserName = "lordhagen.de@gmail.com",
                    NormalizedUserName = "lordhagen.de@gmail.com",
                    PasswordHash = hasher.HashPassword(null, "V0yager21$"),
                    EmailConfirmed = true
                }
                );
        }
    }
}
