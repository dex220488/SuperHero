using SuperHero.DataAccess.Entities.Output;
using System.Collections.Generic;

namespace SuperHero.Web.ViewModels
{
    public class SuperHeroViewModel
    {
        public SuperHeroViewModel()
        {
            SearchOutput = new List<SearchOutput>();
        }

        public string FilteredSearch { get; set; }
        public List<SearchOutput> SearchOutput { get; set; }
    }
}