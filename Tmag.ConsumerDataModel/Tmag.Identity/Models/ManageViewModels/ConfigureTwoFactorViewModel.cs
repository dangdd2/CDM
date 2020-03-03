using System.Collections.Generic;

namespace Tmag.Identity.Models.ManageViewModels
{
    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }

        public ICollection<string> Providers { get; set; }
    }
}
