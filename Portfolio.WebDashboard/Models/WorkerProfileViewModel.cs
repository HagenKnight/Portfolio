using Portfolio.WebDashboard.Models.Base;

namespace Portfolio.WebDashboard.Models
{
    public class WorkerProfileViewModel : BaseViewModel
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string AboutMe { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public int CountryId { get; set; }

        // Navigation property
        public virtual CountryViewModel? Country { get; set; }
    }
}
