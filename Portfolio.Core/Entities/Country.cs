using Portfolio.Core.Entities.Base;

namespace Portfolio.Core.Entities
{
    public class Country : EntityBase<int>
    {
        public string NameEs { get; set; } = string.Empty;
        public string NameEn { get; set; } = string.Empty;
        public string ISO2 { get; set; } = string.Empty;
        public string ISO3 { get; set; } = string.Empty;

        // Navigation property
        public ICollection<WorkerProfile>? WorkerProfile { get; set; }
    }
}
