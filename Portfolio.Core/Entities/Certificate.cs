using Portfolio.Core.Entities.Base;

namespace Portfolio.Core.Entities
{
    public class Certificate : EntityBase<int>
    {
        public string Title { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public DateTime IssueDate { get; set; }
        public string CertificateNumber { get; set; } = string.Empty;
        public string CertificateUrl { get; set; } = string.Empty;

        public int WorkerProfileId { get; set; }

        // Navigation property
        public virtual WorkerProfile? WorkerProfile { get; set; }

    }
}
