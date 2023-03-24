using Portfolio.WebDashboard.Models.Base;

namespace Portfolio.WebDashboard.Models
{
    public class CountryViewModel : BaseViewModel
    {
        public string NameEs { get; set; } = string.Empty;
        public string NameEn { get; set; } = string.Empty;
        public string ISO2 { get; set; } = string.Empty;
        public string ISO3 { get; set; } = string.Empty;
    }
}
