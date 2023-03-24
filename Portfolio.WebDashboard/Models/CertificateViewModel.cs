using Portfolio.WebDashboard.Models.Base;

namespace Portfolio.WebDashboard.Models
{
    public class CertificateViewModel : BaseViewModel
    {
        public string Title { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public DateTime IssueDate { get; set; }
        public string CertificateNumber { get; set; } = string.Empty;
        public string CertificateUrl { get; set; } = string.Empty;

        public int WorkerProfileId { get; set; }
        // Navigation property
        public virtual WorkerProfileViewModel? WorkerProfile { get; set; }
    }
}
