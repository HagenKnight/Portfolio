using Portfolio.Core.Entities.Base;
using Portfolio.Core.Identity;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Core.Entities
{
    public class Resume : EntityBase<int>
    {
        [StringLength(250)]
        public string InstitutionName { get; set; } = string.Empty;

        [StringLength(100)] 
        public string Title { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        
        public string Description { get; set; } = string.Empty;

        public int WorkerProfileId { get; set; }

        // Navigation property
        public virtual WorkerProfile? WorkerProfile { get; set; }

        public int ResumeTypeId { get; set; }
        // Navigation property
        public virtual ResumeType? ResumeType { get; set; }

        public ICollection<AptitudeOnResume>? AptitudeOnResume { get; set; }
    }
}
