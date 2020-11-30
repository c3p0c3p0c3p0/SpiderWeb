using SpiderWeb.io.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace SpiderWeb.io.Domain
{
    public class Reply : AuditedAggregateRoot<Guid>
    {
        public string Body { get; set; }
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }
        public Guid Owner { get; set; }
        public Guid CommentId { get; set; }


        [ForeignKey("CommentId")]
        public Comment Comment { get; set; }
    }
}
