using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SuperHero.DataAccess.Services.Parse
{
    public class Image : ObjectConversion
    {
        public override object Cast(string jsonData)
        {
            var output = new Entities.Output.Image();

            var data = (JObject)JsonConvert.DeserializeObject(jsonData);
            output.Url = data["url"].ToString();
            return output;
        }
    }
}