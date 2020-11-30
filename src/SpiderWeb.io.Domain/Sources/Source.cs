using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace SpiderWeb.io.Sources
{
    public class Source : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public Guid AddedBy { get; set; }
        public double Rating { get; set; }
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }
        public SourceType SourceType { get; set; }
        public string URL { get; set; }
        public ContentType ContentType { get; set; }
        public DateTime PublishDate { get; set; }
        public string Tags { get; set; }
    }

}
