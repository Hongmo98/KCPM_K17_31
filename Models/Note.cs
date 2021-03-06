﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KCPM_DotCover.Models
{

    public class Note
    {
        public int Id { get; set; }

        [Required, MaxLength(50, ErrorMessage = "Cannot 50 character")]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
        public bool Finished { get; set; }

        [Required, MaxLength(50, ErrorMessage = "Cannot 50 character")]
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool Deleted { get; set; }
        [Timestamp]
        public byte[] Timestamp { get; set; }
    }

}
