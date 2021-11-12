using System.Web;
using System.Web.Mvc;

namespace SuperHero.Web.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult Index()
        {
            return View("Error");
        }

        public ViewResult HttpError500()
        {
            if (RouteData.Values.ContainsKey("error"))
            {
                ViewBag.ErrorMessage = ((HttpException)RouteData.Values["error"]).Message;
            }

            Response.StatusCode = 500;
            return View("HttpError500");
        }

        public ViewResult HttpError404()
        {
            Response.StatusCode = 404;
            return View("HttpError404");
        }
    }
}