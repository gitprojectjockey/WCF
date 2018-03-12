using System.Security.Claims;

namespace Postal.Catagalog.MvcClient.IdentityModels
{
    public class AppUserPrinciple : ClaimsPrincipal
    {
        public AppUserPrinciple(ClaimsPrincipal principal) : base(principal) { }

        public string Name => this.FindFirst(ClaimTypes.Name)?.Value;

        public string UserEmail => this.FindFirst(ClaimTypes.Email)?.Value;

        public string Country => this.FindFirst(ClaimTypes.Country)?.Value;

        public bool IsAuthenticated
        {
            get {return (System.Web.HttpContext.Current.User != null) && (System.Web.HttpContext.Current.User.Identity.IsAuthenticated); }
        }
    }
}