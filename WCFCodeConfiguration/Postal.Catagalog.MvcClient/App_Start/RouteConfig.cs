﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Postal.Catagalog.MvcClient
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();


      routes.MapRoute(
        "Default", // Route name
        "{controller}/{action}/{id}", // URL with parameters*
        new
        {
            controller = "Home",
            action = "Index",
            id = UrlParameter.Optional
        }
);
        }
    }
}
