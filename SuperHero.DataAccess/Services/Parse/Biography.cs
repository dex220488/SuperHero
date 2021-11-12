using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace SuperHero.DataAccess.Services.Parse
{
    public class Biography : ObjectConversion
    {
        public override object Cast(string jsonData)
        {
            var output = new Entities.Output.Biography();

            var data = (JObject)JsonConvert.DeserializeObject(jsonData);
            output.Aliases = data["aliases"].Values<string>().ToList();
            output.FullName = data["full-name"].ToString();
            output.AlterEgos = data["alter-egos"].ToString();
            output.PlaceOfBirth = data["place-of-birth"].ToString();
            output.FirstAppearance = data["first-appearance"].ToString();
            output.Publisher = data["publisher"].ToString();
            output.Alignment = data["alignment"].ToString();

            return output;
        }
    }
}