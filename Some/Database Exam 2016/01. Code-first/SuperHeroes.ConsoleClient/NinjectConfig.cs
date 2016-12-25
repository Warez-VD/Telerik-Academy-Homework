using Ninject.Modules;
using System.Data.Entity;
using SuperHeroes.Data;
using SuperHeroes.Models;
using SuperHeroes.Export;

namespace SuperHeroes.ConsoleClient
{
    public class NinjectConfig : NinjectModule
    {
        public override void Load()
        {
            this.Bind<DbContext>().To<SuperHeroesDbContext>().InSingletonScope();
            this.Bind<IUnitOfWork>().To<UnitOfWork>();
            this.Bind<IRepository<Superhero>>().To<SuperHeroesRepository<Superhero>>();
            this.Bind<IRepository<Power>>().To<SuperHeroesRepository<Power>>();
            this.Bind<IRepository<City>>().To<SuperHeroesRepository<City>>();
            this.Bind<IRepository<Planet>>().To<SuperHeroesRepository<Planet>>();
            this.Bind<IRepository<Country>>().To<SuperHeroesRepository<Country>>();
            this.Bind<IRepository<Fraction>>().To<SuperHeroesRepository<Fraction>>();
            this.Bind<IJsonImporter>().To<JsonImporter>();
            this.Bind<SuperheroDataGenerator>().To<SuperheroDataGenerator>();
            this.Bind<ISuperheroesUniverseExporter>().To<SuperHeroesExporter>();
            this.Bind<XmlExporter>().To<XmlExporter>().InSingletonScope();
            this.Bind<IWriter>().To<ConsoleWriter>();
        }
    }
}
