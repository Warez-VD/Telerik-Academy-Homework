using System.Collections.Generic;
using System.Linq;
using SuperHeroes.Data;
using SuperHeroes.Export.XmlModels;
using SuperHeroes.Models;

namespace SuperHeroes.Export
{
    public class SuperheroDataGenerator
    {
        private IRepository<Superhero> superHeroes;
        private IRepository<Fraction> fractions;

        public SuperheroDataGenerator(IRepository<Superhero> superHeroes, IRepository<Fraction> fractions)
        {
            this.superHeroes = superHeroes;
            this.fractions = fractions;
        }

        public List<SuperheroXmlModel> FillWithSuperheroesData()
        {
            var superHeroes = new List<SuperheroXmlModel>();

            var dbSuperHeroes = this.superHeroes.All();

            this.GetFilteredSuperheroes(dbSuperHeroes, superHeroes);

            return superHeroes;
        }

        public List<SuperheroXmlModel> FillWithSuperheroesData(string power)
        {
            var superHeroes = new List<SuperheroXmlModel>();
            var dbSuperHeroes = this.superHeroes.All(s => s.Powers.Any(p => p.Name == power));

            this.GetFilteredSuperheroes(dbSuperHeroes, superHeroes);

            return superHeroes;
        }

        public List<SuperheroXmlModel> FillWithSuperheroesData(string cityName, bool isCity)
        {
            var superHeroes = new List<SuperheroXmlModel>();
            var dbSuperHeroes = this.superHeroes.All(s => s.City.Name == cityName);

            this.GetFilteredSuperheroes(dbSuperHeroes, superHeroes);

            return superHeroes;
        }

        public List<SuperheroXmlModel> FillWithSuperheroesData(object id)
        {
            var superHeroes = new List<SuperheroXmlModel>();
            var searchedId = (int)id;
            var dbSuperHeroes = this.superHeroes.All(s => s.Id == searchedId);

            this.GetFilteredSuperheroes(dbSuperHeroes, superHeroes);

            return superHeroes;
        }

        public List<FractionXmlModel> FillWithFractionsData()
        {
            var fractions = new List<FractionXmlModel>();
            var dbFractions = this.fractions.All();

            this.GetFilteredFractions(dbFractions, fractions);

            return fractions;
        }

        public List<FractionXmlModel> FillWithFractionsData(object id)
        {
            var fractions = new List<FractionXmlModel>();
            var searchedId = (int)id;
            var dbFractions = this.fractions.All(s => s.Id == searchedId);

            this.GetFilteredFractions(dbFractions, fractions);

            return fractions;
        }

        private void GetFilteredFractions(IEnumerable<Fraction> fractions, IList<FractionXmlModel> xmlFractions)
        {
            foreach (var fraction in fractions)
            {
                var xmlPlanets = new List<PlanetXmlModel>();

                var xmlFraction = new FractionXmlModel()
                {
                    Id = fraction.Id,
                    Name = fraction.Name,
                    Members = fraction.SuperHeroes.Count
                };

                foreach (var planet in fraction.Planets)
                {
                    var xmlPlanet = new PlanetXmlModel()
                    {
                        Planet = planet.Name
                    };

                    xmlPlanets.Add(xmlPlanet);
                }

                xmlFraction.Planets = xmlPlanets;
                xmlFractions.Add(xmlFraction);
            }
        }

        private void GetFilteredSuperheroes(IEnumerable<Superhero> superheroes, IList<SuperheroXmlModel> xmlSuperHeroes)
        {
            foreach (var superhero in superheroes)
            {
                var xmlSuperHeroPowers = new List<PowerXmlModel>();

                var xmlSuperHero = new SuperheroXmlModel()
                {
                    Id = superhero.Id,
                    Name = superhero.Name,
                    SecretIdentity = superhero.SecretIdentity,
                    Alignment = superhero.Alignment.ToString(),
                    City = superhero.City.Name
                };

                foreach (var powerSkill in superhero.Powers)
                {
                    var xmlPower = new PowerXmlModel()
                    {
                        Power = powerSkill.Name
                    };

                    xmlSuperHeroPowers.Add(xmlPower);
                }

                xmlSuperHero.Powers = xmlSuperHeroPowers;
                xmlSuperHeroes.Add(xmlSuperHero);
            }
        }
    }
}
