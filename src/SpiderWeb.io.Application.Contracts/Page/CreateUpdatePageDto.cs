using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SpiderWeb.io.Contracts
{
    public class CreateUpdatePageDto
    {
        [Required]
        public string SourceURL { get; set; }
        public string Body { get; set; }
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }
        [Required]
        public Guid SourceId { get; set; }

    }
}
