namespace Portfolio.Core.DTO
{
    public class CountryDTO
    {
        public int Id { get; set; }
        public string NameEs { get; set; } = string.Empty;
        public string NameEn { get; set; } = string.Empty;
        public string ISO2 { get; set; } = string.Empty;
        public string ISO3 { get; set; } = string.Empty;
    }
}
