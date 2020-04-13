﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Data
{
    public class ApplicationRole : IdentityRole<int>
    {
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
        public virtual ICollection<ApplicationRoleClaim> RoleClaims { get; set; }
    }
}
