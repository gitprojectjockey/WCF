using Postal.Catagalog.MvcClient.IdentityModels;
using System.Security.Claims;
using System.Web.Mvc;

namespace Postal.Catagalog.MvcClient.IdentityViewBase
{
    //This is my pageBaseType for all razor view from now on.
    //It allows me access to all MVC razor view methods as well as my AppUserPrinciple Data in any view.
    //Open up /views/web.config and the set the pageBaseType to AppViewPageBase
    public abstract class AppViewPageBase<TModel> : WebViewPage<TModel>
    {
        protected AppUserPrinciple CurrentUser
        {
            get
            {
                return new AppUserPrinciple(this.User as ClaimsPrincipal);
            }
        }
    }

    public abstract class AppViewPage : AppViewPageBase<dynamic>
    {
    }
}