using System.Collections.Generic;

namespace SuperHero.DataAccess.Entities.Output
{
    public class Biography
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string AlterEgos { get; set; }
        public List<string> Aliases { get; set; }
        public string PlaceOfBirth { get; set; }
        public string FirstAppearance { get; set; }
        public string Publisher { get; set; }
        public string Alignment { get; set; }
    }
}