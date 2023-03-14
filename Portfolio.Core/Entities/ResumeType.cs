using Portfolio.Core.Entities.Base;

namespace Portfolio.Core.Entities
{

    public class ResumeType : EntityBase<int>
    {
        public string Name { get; set; } = string.Empty;
        
        // Navigation property
        public Resume? Resume { get; set; }
    }

    public enum ResumeTypeEnum
    {
        WorkExperience = 1,
        Education = 2
    }
}
