using Portfolio.Core.DTO.Resume;

namespace Portfolio.Core.DTO
{
    public class AptitudeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Value { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
