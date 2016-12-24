using System.Collections.Generic;

namespace DatabaseFirst.Importer.Importers
{
    public class TheGreatImporter : IGreatImporter
    {
        private IEnumerable<IImporter> importers;

        public TheGreatImporter(IEnumerable<IImporter> importers)
        {
            this.importers = importers;
        }

        public string ImportAllData()
        {
            foreach (var importer in this.importers)
            {
                importer.Import();
            }

            return "All data is imported successfully.";
        }
    }
}
