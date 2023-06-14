using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Dermapro
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
             name: "servicesDetails",
             url: "service/{category}/{subcategory}/{Type}/{Services}",
             defaults: new { controller = "details", action = "Index", category = UrlParameter.Optional, subcategory = UrlParameter.Optional, Type = UrlParameter.Optional, Services = UrlParameter.Optional }
         );

            routes.MapRoute(
               name: "services",
               url: "services/{category}/{subcategory}",
               defaults: new { controller = "Services", action = "Index", category = UrlParameter.Optional, subcategory = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
