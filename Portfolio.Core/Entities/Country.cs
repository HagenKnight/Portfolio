using Portfolio.Core.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Core.Entities
{
    public class Country : EntityBase<int>
    {
        [StringLength(250)]
        public string NameEs { get; set; } = string.Empty;

        [StringLength(250)] 
        
        public string NameEn { get; set; } = string.Empty;
        [StringLength(2)]
        public string ISO2 { get; set; } = string.Empty;
        
        [StringLength(3)]
        public string ISO3 { get; set; } = string.Empty;

        // Navigation property
        public ICollection<WorkerProfile>? WorkerProfile { get; set; }
    }
}
