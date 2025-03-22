using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //http://localhost:57119/Movie/Released/2025/01 
            //When we wanted to have a custom route, we need to add like this before the default route
            routes.MapRoute(
                    name: "Released",
                    url: "{controller}/{action}/{year}/{month}",
                    defaults: new { controller = "Movie", action = "Released", year = UrlParameter.Optional, month = UrlParameter.Optional },
                    constraints: new { year = @"\d{4}", month = @"\d{2}" }
                );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
