using Portfolio.WebDashboard.Models.Base;

namespace Portfolio.WebDashboard.Models
{
    public class ServiceViewModel : BaseViewModel
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int WorkerProfileId { get; set; }

        // Navigation property
        public virtual WorkerProfileViewModel? WorkerProfile { get; set; }
    }
}
