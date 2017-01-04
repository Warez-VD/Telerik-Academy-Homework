using Ninject;
using DatabaseFirst.Importer;
using DatabaseFirst.Importer.Importers;

namespace DatabaseFirst.ConsoleClient
{
    public class StartUp
    {
        public static void Main()
        {
            var kernel = new StandardKernel(new NinjectConfig());

            var writer = kernel.Get<IWriter>();
            var greatImporter = kernel.Get<IGreatImporter>();
            writer.WriteLine(greatImporter.ImportAllData());
        }
    }
}
