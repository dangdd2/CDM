using Microsoft.AspNetCore.Identity;

namespace Tmag.Identity
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public bool CanCompletlyDeleteConsumer { get; set; }
        public bool CanChangeConsumerEmail { get; set; }
    }
}
