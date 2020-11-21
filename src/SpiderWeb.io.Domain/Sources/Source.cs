using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace SpiderWeb.io.Sources
{
    public class Source : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public SourceType SourceType { get; set; }
        public string? URL { get; set; }
        public ContentType ContentType { get; set; }
        public DateTime PublishDate { get; set; }
        public string Tags { get; set; }
    }
}
