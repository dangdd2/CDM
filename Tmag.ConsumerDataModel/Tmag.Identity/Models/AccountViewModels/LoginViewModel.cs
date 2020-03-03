using System.ComponentModel.DataAnnotations;

namespace Tmag.Identity.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
            
        public bool RememberMe { get; set; }
    }
}
