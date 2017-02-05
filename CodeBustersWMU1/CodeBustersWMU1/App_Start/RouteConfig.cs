using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CodeBustersWMU1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
    "ProductRoute",
    "{controller}/{action}/{fromView}/{id}",
    new
    {
        controller = "Product",
        action = "Products",
        id = UrlParameter.Optional,
        fromView = UrlParameter.Optional,
    });

            // Route for details
            routes.MapRoute(
                "DetailsRoute",
                "Details/Details/{fromView}/{id}",
                new
                {
                    controller = "Details",
                    action = "Details",
                    id = UrlParameter.Optional,
                    fromView = UrlParameter.Optional,
                });
        }
    }
}
