using Microsoft.AspNetCore.Identity;
using SpiderWeb.io.Sources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace SpiderWeb.io.Domain
{
    public class Comment : AuditedAggregateRoot<Guid>
    {
        public string Body { get; set; }
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }
        public Guid Owner { get; set; }
        public Guid PageId { get; set; }


        [ForeignKey("PageId")]
        public Page Page { get; set; }
    }
}
