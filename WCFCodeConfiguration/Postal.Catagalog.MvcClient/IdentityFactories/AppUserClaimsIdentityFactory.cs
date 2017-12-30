using Microsoft.AspNet.Identity;
using Postal.Catagalog.MvcClient.IdentityModels;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Postal.Catagalog.MvcClient.IdentityFactories
{
    public class AppUserClaimsIdentityFactory : ClaimsIdentityFactory<AppDbIdentityUser>
    {
        public override async Task<ClaimsIdentity> CreateAsync(UserManager<AppDbIdentityUser, string> manager, AppDbIdentityUser user, string authenticationType)
        {
            var identity = await base.CreateAsync(manager, user, authenticationType);

            identity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));
            identity.AddClaim(new Claim(ClaimTypes.Country, user.Country));
            identity.AddClaim(new Claim(ClaimTypes.Email, user.Email));

            return identity;
        }
    }
}