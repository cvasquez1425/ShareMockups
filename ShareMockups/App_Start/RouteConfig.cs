using System.Web.Mvc;
using System.Web.Routing;

using ShareMockups.Helper;

namespace ShareMockups
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // MyRootNamespace.Areas.Blogs.Controllers.HomeController.
            // ShareMockups.Areas.SinglePageApps.Controllers.HomeController
            routes.MapAreas("{controller}/{action}/{id}",                       // Routing URL pattern
                "ShareMockups",                                                 // Root NameSpace
                    new[] { "SinglePageApps" });                                // The last argument to the method is a string array of the “areas” in your application.
                        
            // ADDED 11/24/2015
            //routes.MapRootArea("{controller}/{action}/{id}",
            //    "ShareMockups",
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "Default",                                                                        // Route name
                url: "{controller}/{action}/{id}",                                                      // URL with parameters
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }     // Parameters defaults
            );

        }

        // ADDED 11/24/2015
        protected void Application_Start()
        {
            RegisterRoutes(RouteTable.Routes);
        }

    }
}
