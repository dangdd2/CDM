using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Tmag.Identity
{
    public static class AuthOptions
    {
        public const string Issuer = "TmagConsumerDataModel";

        public const string Audience = "https://Tmag.com/";

        public const string Key = "TmagAUthKey101Let5Pl4yG0lf";

        public const int TokenLifetimeInDays = 100;

        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Key));
        }
    }
}
