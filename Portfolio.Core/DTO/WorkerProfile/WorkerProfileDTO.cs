namespace Portfolio.Core.DTO.WorkerProfile
{
    public class WorkerProfileDTO
    {
        public string FirstName { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string AboutMe { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public CountryDTO? Country { get; set; }
    }
}
