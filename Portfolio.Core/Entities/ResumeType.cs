using Portfolio.Core.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Core.Entities
{

    public class ResumeType : EntityBase<int>
    {
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        
        // Navigation property
        public ICollection<Resume>? Resume { get; set; }
    }

    public enum ResumeTypeEnum
    {
        WorkExperience = 1,
        Education = 2
    }
}
