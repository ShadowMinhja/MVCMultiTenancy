using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MultiTenancy
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.Add("DomainRoute", new DomainRoute(
                "minh.us",                                     // Domain with parameters
                "{action}/{id}",                                        // URL with parameters
                new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
            ));

            routes.Add("DomainRoute2", new DomainRoute(
                "{tenant}.minh.us",                                     // Domain with parameters
                "{action}/{id}",                                        // URL with parameters
                new { tenant = "subdomain", controller = "Home", action = "Index", id = "" }  // Parameter defaults
            ));

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
