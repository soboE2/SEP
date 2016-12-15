using System.Web.Mvc;
using System.Web.Routing;

namespace SEP.WEBApi
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
            name: "DefaultApiMvc",
            url: "APIMvc/{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}