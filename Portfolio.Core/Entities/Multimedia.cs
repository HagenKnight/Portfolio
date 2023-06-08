using Portfolio.Core.Entities.Base;

namespace Portfolio.Core.Entities
{
    public class Multimedia : EntityBase<int>
    {
        public string Description { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;

        public int ProjectId { get; set; }
        public virtual Project? Project { get; set; }
    }
}
