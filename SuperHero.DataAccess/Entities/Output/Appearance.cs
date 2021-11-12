using System.Collections.Generic;

namespace SuperHero.DataAccess.Entities.Output
{
    public class Appearance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public List<string> Height { get; set; }
        public List<string> Weight { get; set; }
        public string EyeColor { get; set; }
        public string HairColor { get; set; }
    }
}