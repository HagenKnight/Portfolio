using Portfolio.Core.Entities.Base;

namespace Portfolio.Core.Entities
{
    public class Aptitude : EntityBase<int>
    {
        public string Name { get; set; } = string.Empty;
        public int Value { get; set; }

        public ICollection<AptitudeOnResume>? AptitudeOnResume { get; set; }
        public ICollection<AptitudeOnProject>? AptitudeOnProject { get; set; }
    }
}
