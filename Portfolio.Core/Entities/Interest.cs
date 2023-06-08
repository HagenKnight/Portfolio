using Portfolio.Core.Entities.Base;

namespace Portfolio.Core.Entities
{
    public class Interest : EntityBase<int>
    {
        public string Name { get; set; } = string.Empty;
        public int WorkerProfileId { get; set; }

        // Navigation property
        public virtual WorkerProfile? WorkerProfile { get; set; }
    }
}
