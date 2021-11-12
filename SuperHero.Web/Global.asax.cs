using SuperHero.Web.Controllers;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SuperHero.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var exception = Server.GetLastError();

            var httpException = exception as HttpException;
            var routeData = new RouteData();

            routeData.Values.Add("controller", "Error");

            if (httpException == null)
                routeData.Values.Add("action", "Index");
            else //It's an Http Exception, Let's handle it.
                switch (httpException.GetHttpCode())
                {
                    case 404:
                        // Page not found.
                        routeData.Values.Add("action", "HttpError404");
                        break;

                    case 500:
                        // Server error.
                        routeData.Values.Add("action", "HttpError500");
                        break;

                    default:
                        routeData.Values.Add("action", "Index");
                        break;
                }

            // Pass exception details to the target error View.
            routeData.Values.Add("error", exception);

            var request = Request;
            // Pass request details to the target request View.
            routeData.Values.Add("request", request);

            // Clear the error on server.
            Server.ClearError();

            // Avoid IIS7 getting in the middle
            Response.TrySkipIisCustomErrors = true;

            // Call target Controller and pass the routeData.
            IController errorController = new ErrorController();
            errorController.Execute(new RequestContext(new HttpContextWrapper(Context), routeData));
        }
    }
}