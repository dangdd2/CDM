using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Tmag.Identity
{
    public class UserClaimResolver : IUserClaimResolver
    {
        private IHttpContextAccessor _contextAccessor = null;
        public UserClaimResolver(string userId)
        {

        }
        public UserClaimResolver(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public ClaimsPrincipal Resolve()
        {
            if (_contextAccessor != null)
                return _contextAccessor.HttpContext.User;
            else
                return new ClaimsPrincipal();
        }
    }
}
