using Portfolio.Core.Entities.Base;

namespace Portfolio.Core.Entities
{
    public class WorkerProfile : EntityBase<int>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string AboutMe { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public int CountryId { get; set; }

        // Navigation property
        public virtual Country? Country { get; set; }

        // Navigation property
        public ICollection<Resume>? Resume { get; set; }
        public ICollection<Service>? Service { get; set; }
        public ICollection<Certificate>? Certificate { get; set; }
    }
}
