﻿using Portfolio.Core.Entities.Base;

namespace Portfolio.Core.Entities
{
    public class WorkerProfile : EntityBase<int>
    {
        public string FirstName { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
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
        public Resume? Resume { get; set; }
        public Service? Service { get; set; }
        public Certificate? Certificate { get; set; }
    }
}
