using Portfolio.Core.Entities.Base;

namespace Portfolio.Core.Entities
{
    public class Project : EntityBase<int>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ClientName { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Url { get; set; } = string.Empty;
        public string Testimonial { get; set; } = string.Empty;

        public int WorkerProfileId { get; set; }

        // Navigation property
        public virtual WorkerProfile? WorkerProfile { get; set; }

        public ICollection<Multimedia>? Multimedia { get; set; }
        public ICollection<AptitudeOnProject>? AptitudeOnProject { get; set; }
    }
}
