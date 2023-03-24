using Portfolio.WebDashboard.Models.Base;

namespace Portfolio.WebDashboard.Models
{
    public class ResumeViewModel : BaseViewModel
    {
        public string InstitutionName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Description { get; set; } = string.Empty;

        public int WorkerProfileId { get; set; }

        // Navigation property
        public virtual WorkerProfileViewModel? WorkerProfile { get; set; }

        public int ResumeTypeId { get; set; }
        // Navigation property
        public virtual ResumeTypeViewModel? ResumeType { get; set; }
    }
}
