using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SuperHero.DataAccess.Services.Parse
{
    public class Connections : ObjectConversion
    {
        public override object Cast(string jsonData)
        {
            var output = new Entities.Output.Connections();

            var data = (JObject)JsonConvert.DeserializeObject(jsonData);
            output.GroupAffiliation = data["group-affiliation"].ToString();
            output.Relatives = data["relatives"].ToString();

            return output;
        }
    }
}