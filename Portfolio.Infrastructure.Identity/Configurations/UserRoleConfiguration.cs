using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portfolio.Infrastructure.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "b74a74c4-2e22-4dc8-a7ed-8a719397d81d",
                    UserId = "a62397d8-ce0d-4dfe-a2ff-684f581b2488"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "f04f16bc-d91e-468e-9837-ace2532c798e",
                    UserId = "d10fb303-28e4-4e13-a678-7dc5f3a134ad"
                }
            );
        }
    }
}
