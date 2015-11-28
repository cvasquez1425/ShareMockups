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

            // ShareMockups.Areas.SinglePageApps.Controllers
            routes.MapAreas("{controller}/{action}/{id}",
               "ShareMockups",
               new[] { "SinglePageApps", "Forums" });

            routes.MapRootArea("{controller}/{action}/{id}",
                "ShareMockups",
                new { controller = "Home", action = "Index", id = "" });

            //RouteDebug.RouteDebugger.RewriteRoutesForTesting(RouteTable.Routes);

            //routes.MapRoute(
            //    name: "Default",                                                                        // Route name
            //    url: "{controller}/{action}/{id}",                                                      // URL with parameters
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }    // Parameters defaults
            //);

        }

        // ADDED 11/24/2015
        protected void Application_Start()
        {
            RegisterRoutes(RouteTable.Routes);
        }

    }
}
