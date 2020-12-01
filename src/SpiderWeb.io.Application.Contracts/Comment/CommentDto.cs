using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SpiderWeb.io.Application
{
    public class CommentDto  : AuditedEntityDto<Guid>
    {
        public string Body { get; set; }
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }
        public Guid Owner { get; set; }
        public Guid PageId { get; set; }
    }
}
