using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SpiderWeb.io.Application
{
    public class PageDto  : AuditedEntityDto<Guid>
    {
        public string SourceURL { get; set; }
        public string Body { get; set; }
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }
        public Guid SourceId { get; set; }
    }
}
