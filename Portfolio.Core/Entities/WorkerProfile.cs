using Portfolio.Core.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Core.Entities
{

    /// <summary>
    /// Employee profile
    /// </summary>
    public class WorkerProfile : EntityBase<int>
    {
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;
        
        [StringLength(100)]
        public string LastName { get; set; } = string.Empty;
        
        public string AboutMe { get; set; } = string.Empty;
        
        public DateTime BirthDate { get; set; }
        
        [StringLength(30)]
        public string Email { get; set; } = string.Empty;
        
        [StringLength(20)]
        public string Phone { get; set; } = string.Empty;
        
        [StringLength(50)]
        public string Address { get; set; } = string.Empty;
        
        [StringLength(50)]
        public string City { get; set; } = string.Empty;
        public int CountryId { get; set; }

        // Navigation property
        public virtual Country? Country { get; set; }

        // Navigation property
        public ICollection<Resume>? Resume { get; set; }
        public ICollection<Service>? Service { get; set; }
        public ICollection<Certificate>? Certificate { get; set; }
        public ICollection<Project>? Project { get; set; }
        public ICollection<Interest>? Interest { get; set; }
        public ICollection<LanguagesOnWorkerProfile>? LanguagesOnWorkerProfile { get; set; }

    }
}
