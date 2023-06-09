﻿using Portfolio.Core.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Core.Entities
{
    public class Service : EntityBase<int>
    {
        [StringLength(80)]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int WorkerProfileId { get; set; }

        // Navigation property
        public virtual WorkerProfile? WorkerProfile { get; set; }

    }
}
