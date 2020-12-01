﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using SpiderWeb.io.DomainShared;

namespace SpiderWeb.io.Sources
{
    public class CreateUpdateSourceDto
    {
        [Required]
        [StringLength(250)]
        public string Name { get; set; }
        [Required]
        public SourceType SourceType { get; set; }
        public string? URL { get; set; }
        [Required]
        public ContentType ContentType { get; set; }
        public DateTime PublishDate { get; set; } = DateTime.Now;
        public string Tags { get; set; }  
        public Guid AddedBy { get; set; }
        public double Rating { get; set; }
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }
  
    }
}
