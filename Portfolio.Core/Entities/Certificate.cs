using Portfolio.Core.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Core.Entities
{
    public class Certificate : EntityBase<int>
    {
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;
        
        [StringLength(30)]
        public string Duration { get; set; } = string.Empty;
        public DateTime IssueDate { get; set; }
        
        [StringLength(50)]
        public string CertificateNumber { get; set; } = string.Empty;
        public string CertificateUrl { get; set; } = string.Empty;

        public int WorkerProfileId { get; set; }

        // Navigation property
        public virtual WorkerProfile? WorkerProfile { get; set; }

    }
}
