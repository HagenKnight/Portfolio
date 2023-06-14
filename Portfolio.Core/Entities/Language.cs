using Portfolio.Core.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Core.Entities
{
    public class Language : EntityBase<int>
    {
        [StringLength(50)]
        public string NameEn { get; set; } = string.Empty;
        [StringLength(50)]
        public string NameEs { get; set; } = string.Empty;
        public ICollection<LanguagesOnWorkerProfile>? LanguagesOnWorkerProfile { get; set; }
    }
}
