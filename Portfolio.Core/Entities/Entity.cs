using Portfolio.Core.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Core.Entities
{
    [NotMapped]
    public class Entity : EntityBase<int>
    {
        public string Name { get; set; } = string.Empty;
    }
}
