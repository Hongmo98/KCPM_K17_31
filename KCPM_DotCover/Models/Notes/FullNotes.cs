﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KCPM_DotCover.Models.Notes
{
    public class FullNotes : AuditBaseModel
    {
        [Required(ErrorMessage = "Please input this field")]
        [StringLength(50, ErrorMessage = "50 characters maximum")]
        public string Title { get; set; }

        [StringLength(255, ErrorMessage = "255 characters maximum")]
        public string Description { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Please input this field")]
        public DateTime Reminder { get; set; }


    }

}
