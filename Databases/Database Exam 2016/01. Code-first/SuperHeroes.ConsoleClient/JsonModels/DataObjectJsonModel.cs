using System.Collections.Generic;

namespace SuperHeroes.ConsoleClient.JsonModels
{
    public class DataObjectJsonModel
    {
        public IEnumerable<DataJsonModel> Data { get; set; }
    }
}
