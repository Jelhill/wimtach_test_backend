
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ProJeliliV1.Models
{
    public class College : FullAuditedEntity<int>, IPassivable
    {
        public College()
        {
            this.IsActive = true;
            this.CreationTime = DateTime.Now;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public double GPSLatitude { get; set; }
        public double GPSLongitude { get; set; }
        public string Email { get; set; }
        public string JeliliString { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Student> Students { get; set; }

    }
}