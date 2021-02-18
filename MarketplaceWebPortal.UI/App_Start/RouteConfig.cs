using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MarketplaceWebPortal.UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.config");
            routes.MapRoute(
                name: "Compare",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "ProductDetail", action = "Compare", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "ProductDetail", action = "Detail", id = UrlParameter.Optional }
            );
        }
    }
}
