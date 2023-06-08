using Portfolio.Core.Entities.Base;

namespace Portfolio.Core.Entities
{
    public class AptitudeOnResume : EntityBase<int>
    {
        public int AptitudeId { get; set; }
        public int ResumeId { get; set; }

        public virtual Aptitude? Aptitude { get; set; }
        public virtual Resume? Resume { get; set; }
    }
}
