using Microsoft.AspNetCore.Identity;

namespace TestApp.Data
{
    public class ApplicationRoleClaim : IdentityRoleClaim<int>
    {
        public virtual ApplicationRole Role { get; set; }
    }
}