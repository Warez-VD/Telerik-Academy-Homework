using System.Collections.Generic;

namespace SuperHeroes.ConsoleClient.JsonModels
{
    public class DataJsonModel
    {
        public string Name { get; set; }

        public string SecretIdentity { get; set; }

        public CityJsonModel City { get; set; }

        public string Alignment { get; set; }

        public string Story { get; set; }

        public IEnumerable<string> Powers { get; set; }

        public IEnumerable<string> Fractions { get; set; }
    }
}
