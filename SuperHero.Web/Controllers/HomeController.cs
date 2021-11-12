using SuperHero.DataAccess.Entities.Output;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SuperHero.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult index(string txtsearchname)
        {
            var data = new ViewModels.SuperHeroViewModel();

            if (!string.IsNullOrEmpty(txtsearchname))
            {
                data.FilteredSearch = txtsearchname;
                data.SearchOutput = GetSearchedValues(txtsearchname);
                //Response.Cookies["filteredSearch"].Value = txtsearchname;
            }
            else
            {
                //if (Request.Cookies["filteredSearch"] != null)
                //{
                //    //txtsearchname = Request.Cookies["filteredSearch"].Value;
                //}
            }

            //data.FilteredSearch = txtsearchname;
            //data.SearchOutput = GetSearchedValues(txtsearchname);
            return View(data);
        }

        private List<SearchOutput> GetSearchedValues(string searchedValued)
        {
            var data = new List<SearchOutput>();
            if (!String.IsNullOrEmpty(searchedValued))
            {
                var service = new Services.Service();
                data = service.GetSearchList(searchedValued);
            }

            return data;
        }
    }
}