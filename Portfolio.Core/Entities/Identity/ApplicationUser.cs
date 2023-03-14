using Microsoft.AspNetCore.Identity;

namespace Portfolio.Core.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
    }
}
