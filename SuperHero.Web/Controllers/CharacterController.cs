using SuperHero.DataAccess.Entities.Output;
using System.Web;
using System.Web.Mvc;

namespace SuperHero.Web.Controllers
{
    public class CharacterController : Controller
    {
        public ActionResult Index(int id)
        {
            var data = GetSearchedValues(id);

            if (data.Id == 0)
            {
                throw new HttpException(404, "not found");
            }

            return View(data);

        }

        private SearchOutput GetSearchedValues(int searchedValued)
        {
            var service = new Services.Service();
            return service.GetSearchById(searchedValued);
        }
    }
}