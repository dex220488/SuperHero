using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SuperHero.DataAccess.Services.Parse
{
    public class Work : ObjectConversion
    {
        public override object Cast(string jsonData)
        {
            var output = new Entities.Output.Work();

            var data = (JObject)JsonConvert.DeserializeObject(jsonData);
            output.Occupation = data["occupation"].ToString();
            output.Base = data["base"].ToString();

            return output;
        }
    }
}