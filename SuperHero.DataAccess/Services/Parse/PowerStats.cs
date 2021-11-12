using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SuperHero.DataAccess.Services.Parse
{
    public class PowerStats : ObjectConversion
    {
        public override object Cast(string jsonData)
        {
            var output = new Entities.Output.PowerStats();

            var data = (JObject)JsonConvert.DeserializeObject(jsonData);
            int.TryParse(data["intelligence"].ToString(), out int intelligence);
            int.TryParse(data["strength"].ToString(), out int strength);
            int.TryParse(data["speed"].ToString(), out int speed);
            int.TryParse(data["durability"].ToString(), out int durability);
            int.TryParse(data["power"].ToString(), out int power);
            int.TryParse(data["combat"].ToString(), out int combat);

            output.Intelligence = intelligence;
            output.Strength = strength;
            output.Speed = speed;
            output.Durability = durability;
            output.Power = power;
            output.Combat = combat;
            return output;
        }
    }
}