using Portfolio.Core.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Core.Entities
{
    public class Aptitude : EntityBase<int>
    {
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        public int Value { get; set; }

        public ICollection<AptitudeOnResume>? AptitudeOnResume { get; set; }
        public ICollection<AptitudeOnProject>? AptitudeOnProject { get; set; }
    }
}
