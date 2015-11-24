using System.Web.Mvc;
using System.Web.Routing;

namespace ShareMockups.Helper
{
    public static class RouteHelper
    {
        public static Route MapAreas(this RouteCollection routes, string RoutingUrl, string RootNameSpace, string[] Areas)
        {
           return routes.MapRoute("ShareMockups", "{ controller}/{ action}/{ id}", new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }

        //public static Route MapRootArea(this RouteCollection routes, string RoutingUrl, string RootNameSpace, string Areas)
        //{

        //}

    }
}