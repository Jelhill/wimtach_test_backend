using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace ProJeliliV1.Models
{
    public class Student : FullAuditedEntity<int>, IPassivable
    {
        public Student()
        {
            this.IsActive = true;
            this.CreationTime = DateTime.Now;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ProgramName { get; set; }
        public string DoB { get; set; }
        public bool IsActive { get; set; }
    }
}
