using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Tmag.Identity;

namespace Tmag.ConsumerDataModelApi.Controllers
{

    [Route("api/[controller]")]
    [Authorize]
    public class AuthUserController : IdentityController
    {
        public AuthUserController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager) 
            : base(userManager, signInManager)
        {
        }
    }
}
