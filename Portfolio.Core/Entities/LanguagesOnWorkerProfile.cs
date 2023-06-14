using Portfolio.Core.Entities.Base;

namespace Portfolio.Core.Entities
{
    public class LanguagesOnWorkerProfile : EntityBase<int>
    {
        public int LanguageId { get; set; }
        public int WorkerProfileId { get; set; }

        // Navigation property
        public virtual Language? Language { get; set; }
        public virtual WorkerProfile? WorkerProfile { get; set; }
    }
}
