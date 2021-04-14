using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace LocalLibrary.Entity
{
    public class Book : AuditedAggregateRoot<Guid>
    {
        
        public string Title { get;  set; }        
        public string Author { get; set; }
        public Section Section { get; set; }
  

    }
}