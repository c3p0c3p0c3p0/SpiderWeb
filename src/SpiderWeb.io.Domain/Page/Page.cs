
using SpiderWeb.io.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace SpiderWeb.io.Domain
{
    public class Page : AuditedAggregateRoot<Guid>
    {
        public string SourceURL { get; set; }
        public string Body { get; set; }
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }
        public Guid SourceId { get; set; }

        [ForeignKey("SourceId")]
        public Source Source { get; set; }
    }
}
