using Ninject;
using System.Data.Entity;
using SuperHeroes.Data;
using SuperHeroes.Data.Migrations;
using SuperHeroes.Export;

namespace SuperHeroes.ConsoleClient
{
    public class StartUp
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SuperHeroesDbContext, Configuration>());
            
            var kernel = new StandardKernel(new NinjectConfig());
            var context = kernel.Get<DbContext>();
            context.Database.CreateIfNotExists();

            var writer = kernel.Get<IWriter>();

            var importer = kernel.Get<IJsonImporter>();
            writer.WriteLine(importer.ParseJson());
            
            var exporter = kernel.Get<ISuperheroesUniverseExporter>();
            writer.WriteLine(exporter.ExportAllSuperheroes());
            writer.WriteLine(exporter.ExportSupperheroesWithPower("Martial arts"));
            writer.WriteLine(exporter.ExportSuperheroesByCity("New York"));
            writer.WriteLine(exporter.ExportSuperheroDetails(6));
            writer.WriteLine(exporter.ExportFractions());
            writer.WriteLine(exporter.ExportFractionDetails(3));
        }
    }
}
