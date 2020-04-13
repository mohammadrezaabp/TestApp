using Microsoft.AspNetCore.Identity;

namespace TestApp.Data
{
    public class ApplicationUserLogin : IdentityUserLogin<int>
    {
        public virtual ApplicationUser User { get; set; }
    }
}