using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebMVCRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Search",
                url: "product/search/{productID}",
                defaults: new { controller = "Product", action = "Details", productID = UrlParameter.Optional },
                constraints: new { productID = @"\d+" }
                );

            routes.MapRoute(
                name:"Products",
                url:"products/allproducts",
                defaults: new { controller = "Product", action = "Index" }
                );

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}
