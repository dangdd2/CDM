using System.Security.Claims;

namespace Tmag.Identity
{
    public interface IUserClaimResolver
    {
        ClaimsPrincipal Resolve();
    }
}