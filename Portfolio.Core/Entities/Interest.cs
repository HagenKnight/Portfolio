using Portfolio.Core.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Core.Entities
{
    public class Interest : EntityBase<int>
    {
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        public int WorkerProfileId { get; set; }

        // Navigation property
        public virtual WorkerProfile? WorkerProfile { get; set; }
    }
}
