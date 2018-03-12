using System.Web;
using System.Web.Mvc;

namespace Postal.Catagalog.MvcClient
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            //It is good practice to make your appliation secure by default and then whitelist the 
            //controllers /actions that allow anonymous access. 
            //To do this we'll add the built in AuthorizeAttribute as a global filter.
            filters.Add(new AuthorizeAttribute());
        }
    }
}
