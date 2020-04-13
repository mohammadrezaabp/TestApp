﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Data
{
    public class LeaveType : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
