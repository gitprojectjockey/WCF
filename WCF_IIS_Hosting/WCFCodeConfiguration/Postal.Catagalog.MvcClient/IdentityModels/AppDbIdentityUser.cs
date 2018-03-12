using Microsoft.AspNet.Identity.EntityFramework;

namespace Postal.Catagalog.MvcClient.IdentityModels
{
    public class AppDbIdentityUser : IdentityUser
    {
        // inherits email and name
        public string Country { get; set; }
    }
}