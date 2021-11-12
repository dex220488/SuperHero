using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero.DataAccess.Entities.Api
{
    public class Enums
    {
        public enum ApiGetOptions
        {
            Search,
            Id,
            Powerstats,
            Biography,
            Appearance,
            Work,
            Connections,
            Image
        }
    }
}
