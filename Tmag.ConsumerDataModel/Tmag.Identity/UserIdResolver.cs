using Microsoft.AspNetCore.Identity;

namespace Tmag.Identity
{
    public class UserIdResolver : IUserIdResolver
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserClaimResolver _userClaimResolver;

        public UserIdResolver(IUserClaimResolver userClaimResolver, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _userClaimResolver = userClaimResolver;
        }
        public string Resolve()
        {
            var userid = _userManager.GetUserId(_userClaimResolver.Resolve());
           
            return userid;
        }
    }
}
