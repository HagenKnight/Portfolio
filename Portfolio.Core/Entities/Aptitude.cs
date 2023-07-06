using Portfolio.Core.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Core.Entities
{
    /// <summary>
    /// Technical or soft skills required in work experience or projects
    /// </summary>
    public class Aptitude : EntityBase<int>
    {
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        public ICollection<AptitudeOnResume>? AptitudeOnResume { get; set; }
        public ICollection<AptitudeOnProject>? AptitudeOnProject { get; set; }
    }
}
