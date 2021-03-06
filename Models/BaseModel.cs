﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KCPM_DotCover.Models
{
    public abstract class BaseModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public byte[] Timestamp { get; set; }
    }
}
