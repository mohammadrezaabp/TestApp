﻿using Microsoft.AspNetCore.Identity;

namespace TestApp.Data
{
    public class ApplicationUserToken : IdentityUserToken<int>
    {
        public virtual ApplicationUser User { get; set; }
    }
}