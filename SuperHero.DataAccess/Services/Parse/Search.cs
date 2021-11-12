using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SuperHero.DataAccess.Entities.Output;
using System.Collections.Generic;

namespace SuperHero.DataAccess.Services.Parse
{
    public class Search : ObjectConversion
    {
        public override object Cast(string jsonData)
        {
            var output = new List<SearchOutput>();
            var data = (JArray)JsonConvert.DeserializeObject(jsonData);
            foreach (var item in data)
            {
                int id = int.Parse(item["id"].ToString());
                string name = item["name"].ToString();
                var appearanceCast = new Services.Parse.Appearance();
                var biographyCast = new Services.Parse.Biography();
                var connectionsCast = new Services.Parse.Connections();
                var imageCast = new Services.Parse.Image();
                var powerStatsCast = new Services.Parse.PowerStats();
                var workCast = new Services.Parse.Work();

                output.Add(new SearchOutput
                {
                    Id = id,
                    Name = name,
                    Appearance = (Entities.Output.Appearance)appearanceCast.Cast(item["appearance"].ToString()),
                    Biography = (Entities.Output.Biography)biographyCast.Cast(item["biography"].ToString()),
                    Connections = (Entities.Output.Connections)connectionsCast.Cast(item["connections"].ToString()),
                    Image = (Entities.Output.Image)imageCast.Cast(item["image"].ToString()),
                    PowerStats = (Entities.Output.PowerStats)powerStatsCast.Cast(item["powerstats"].ToString()),
                    Work = (Entities.Output.Work)workCast.Cast(item["work"].ToString()),
                });
            }

            return output;
        }
    }
}