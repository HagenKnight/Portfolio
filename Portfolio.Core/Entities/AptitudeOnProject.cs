using Portfolio.Core.Entities.Base;

namespace Portfolio.Core.Entities
{
    public class AptitudeOnProject : EntityBase<int>
    {
        public int AptitudeId { get; set; }
        public int ProjectId { get; set; }
        public virtual Aptitude? Aptitude { get; set; }
        public virtual Project? Resume { get; set; }
    }
}
