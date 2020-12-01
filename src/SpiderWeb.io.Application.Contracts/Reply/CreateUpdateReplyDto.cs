using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SpiderWeb.io.Contracts
{
    public class CreateUpdateReplyDto
    {

        public string Body { get; set; }
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }
        public Guid Owner { get; set; }

        [Required]
        public Guid CommentId { get; set; }

    }
}
