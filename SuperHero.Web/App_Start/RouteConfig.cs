using System.Web.Mvc;
using System.Web.Routing;

namespace SuperHero.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",
                "{controller}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }  // Parameter defaults
            );
        }
    }
}