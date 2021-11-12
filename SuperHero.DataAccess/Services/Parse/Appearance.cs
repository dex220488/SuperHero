using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace SuperHero.DataAccess.Services.Parse
{
    public class Appearance : ObjectConversion
    {
        public override object Cast(string jsonData)
        {
            var output = new Entities.Output.Appearance();
            var data = (JObject)JsonConvert.DeserializeObject(jsonData);
            output.Weight = data["weight"].Values<string>().ToList();
            output.Gender = data["gender"].ToString();
            output.Race = data["race"].ToString();
            output.Height = data["height"].Values<string>().ToList();
            output.EyeColor = data["eye-color"].ToString();
            output.HairColor = data["hair-color"].ToString();

            return output;
        }
    }
}