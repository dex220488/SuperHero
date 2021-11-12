using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SuperHero.DataAccess.Entities.Output;

namespace SuperHero.DataAccess.Services.Parse
{
    public class SearchId : ObjectConversion
    {
        public override object Cast(string jsonData)
        {
            var output = new SearchOutput();
            var item = (JObject)JsonConvert.DeserializeObject(jsonData);

            int id = int.Parse(item["id"].ToString());
            string name = item["name"].ToString();
            var appearanceCast = new Services.Parse.Appearance();
            var biographyCast = new Services.Parse.Biography();
            var connectionsCast = new Services.Parse.Connections();
            var imageCast = new Services.Parse.Image();
            var powerStatsCast = new Services.Parse.PowerStats();
            var workCast = new Services.Parse.Work();

            output.Id = id;
            output.Name = name;
            output.Appearance = (Entities.Output.Appearance)appearanceCast.Cast(item["appearance"].ToString());
            output.Biography = (Entities.Output.Biography)biographyCast.Cast(item["biography"].ToString());
            output.Connections = (Entities.Output.Connections)connectionsCast.Cast(item["connections"].ToString());
            output.Image = (Entities.Output.Image)imageCast.Cast(item["image"].ToString());
            output.PowerStats = (Entities.Output.PowerStats)powerStatsCast.Cast(item["powerstats"].ToString());
            output.Work = (Entities.Output.Work)workCast.Cast(item["work"].ToString());

            return output;
        }
    }
}