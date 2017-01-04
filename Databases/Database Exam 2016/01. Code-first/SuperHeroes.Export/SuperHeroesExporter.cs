using SuperHeroes.Export.XmlModels;

namespace SuperHeroes.Export
{
    public class SuperHeroesExporter : ISuperheroesUniverseExporter
    {
        private SuperheroDataGenerator dataGenrator;
        private XmlExporter exporter;

        public SuperHeroesExporter(SuperheroDataGenerator dataGenrator, XmlExporter exporter)
        {
            this.dataGenrator = dataGenrator;
            this.exporter = exporter;
        }

        public string ExportAllSuperheroes()
        {
            var data = this.dataGenrator.FillWithSuperheroesData();
            var superheroes =
                new SuperheroesXmlModel
                {
                    Superheroes = data
                };

            this.exporter.ExportSuperheroesXml(superheroes, "All Superheroes");

            return "All superheroes xml created.";
        }

        public string ExportFractionDetails(object fractionId)
        {
            var data = this.dataGenrator.FillWithFractionsData(fractionId);
            var fractions =
                new FractionsXmlModel
                {
                    Fractions = data
                };

            this.exporter.ExportFractionsXml(fractions, "FractionWithSpecificId");

            return $"Fraction with {fractionId} id xml created.";
        }

        public string ExportFractions()
        {
            var data = this.dataGenrator.FillWithFractionsData();
            var fractions =
                new FractionsXmlModel
                {
                    Fractions = data
                };

            this.exporter.ExportFractionsXml(fractions, "All Fractions");

            return "All fractions xml created.";
        }

        public string ExportSuperheroDetails(object superheroId)
        {
            var data = this.dataGenrator.FillWithSuperheroesData(superheroId);
            var superheroes =
                new SuperheroesXmlModel
                {
                    Superheroes = data
                };

            this.exporter.ExportSuperheroesXml(superheroes, "SuperheroWithSpecificId");

            return $"Superhero with {superheroId} id xml created.";
        }

        public string ExportSuperheroesByCity(string cityName)
        {
            bool justToOverrideTheMethod = true;
            var data = this.dataGenrator.FillWithSuperheroesData(cityName, justToOverrideTheMethod);
            var superheroes =
                new SuperheroesXmlModel
                {
                    Superheroes = data
                };

            this.exporter.ExportSuperheroesXml(superheroes, "SuperheroesWithSpecificCity");

            return $"All superheroes with {cityName} city xml created.";
        }

        public string ExportSupperheroesWithPower(string power)
        {
            var data = this.dataGenrator.FillWithSuperheroesData(power);
            var superheroes =
                new SuperheroesXmlModel
                {
                    Superheroes = data
                };

            this.exporter.ExportSuperheroesXml(superheroes, "SuperheroesWithSpecificPower");

            return $"All superheroes with {power} power xml created.";
        }
    }
}
