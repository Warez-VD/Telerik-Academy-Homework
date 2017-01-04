using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using SuperHeroes.ConsoleClient.JsonModels;
using SuperHeroes.Data;
using SuperHeroes.Models;

namespace SuperHeroes.ConsoleClient
{
    public class JsonImporter : IJsonImporter
    {
        private IUnitOfWork unitOfWork;
        private IRepository<Planet> planets;
        private IRepository<Country> countries;
        private IRepository<City> cities;
        private IRepository<Power> powers;
        private IRepository<Superhero> superheroes;
        private IRepository<Fraction> fractions;

        public JsonImporter(IRepository<Planet> planets, IRepository<Country> countries, IRepository<City> cities, IRepository<Power> powers, IRepository<Superhero> superheroes, IRepository<Fraction> fractions, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.planets = planets;
            this.countries = countries;
            this.cities = cities;
            this.powers = powers;
            this.superheroes = superheroes;
            this.fractions = fractions;
        }

        public string ParseJson()
        {
            var files = Directory.GetFiles("../../../../02. Json-Data").Where(fileName => fileName.EndsWith(".json")).ToList();

            foreach (var file in files)
            {
                var fileContent = File.ReadAllText(file);
                var fileHeroes = JsonConvert.DeserializeObject<DataObjectJsonModel>(fileContent);
                this.AddToDatabase(fileHeroes);
            }

            return "Imported data in database successfully";
        }

        private void AddToDatabase(DataObjectJsonModel heroesToAdd)
        {
            var data = heroesToAdd.Data;
            var uniquePlanets = new HashSet<string>();
            var uniqueCounties = new HashSet<string>();
            var uniqueCities = new HashSet<string>();
            var uniqueHeroes = new HashSet<string>();
            var uniquePowers = new HashSet<string>();
            var uniqueFractions = new HashSet<string>();

            foreach (var hero in data)
            {
                if (uniqueHeroes.Contains(hero.Name))
                {
                    continue;
                }
                
                var city = this.ProcessCity(hero.City, uniquePlanets, uniqueCounties, uniqueCities);
                var superHero = new Superhero()
                {
                    Name = hero.Name,
                    SecretIdentity = hero.SecretIdentity,
                    Alignment = (Alignment)Enum.Parse(typeof(Alignment), hero.Alignment),
                    City = city,
                    Story = hero.Story
                };
                uniqueHeroes.Add(superHero.Name);

                foreach (var power in hero.Powers)
                {
                    if (!uniquePowers.Contains(power))
                    {
                        var newPower = new Power()
                        {
                            Name = power
                        };

                        this.powers.Add(newPower);
                        this.unitOfWork.Commit();
                        uniquePowers.Add(power);
                    }

                    var currentPower = this.powers.All(p => p.Name == power).FirstOrDefault();
                    superHero.Powers.Add(currentPower);
                }

                if (hero.Fractions != null)
                {
                    foreach (var fraction in hero.Fractions)
                    {
                        if (!uniqueFractions.Contains(fraction))
                        {
                            var newFraction = new Fraction()
                            {
                                Name = fraction,
                                Alignment = superHero.Alignment
                            };

                            newFraction.Planets.Add(superHero.City.Country.Planet);
                            this.fractions.Add(newFraction);
                            this.unitOfWork.Commit();
                            uniqueFractions.Add(fraction);
                        }

                        var currentFraction = this.fractions.All(f => f.Name == fraction).FirstOrDefault();
                        superHero.Fractions.Add(currentFraction);
                    }
                }

                this.superheroes.Add(superHero);
            }

            this.unitOfWork.Commit();
        }

        private City ProcessCity(CityJsonModel city, ICollection<string> uniquePlanets, ICollection<string> uniqueCounties, ICollection<string> uniqueCities)
        {
            if (!uniquePlanets.Contains(city.Planet))
            {
                var newPlanet = new Planet()
                {
                    Name = city.Planet
                };

                uniquePlanets.Add(city.Planet);
                this.planets.Add(newPlanet);
                this.unitOfWork.Commit();
            }

            var planet = this.planets.All(p => p.Name == city.Planet).FirstOrDefault();

            if (!uniqueCounties.Contains(city.Country))
            {
                var newCountry = new Country()
                {
                    Name = city.Country,
                    Planet = planet
                };

                uniqueCounties.Add(city.Country);
                this.countries.Add(newCountry);
                this.unitOfWork.Commit();
            }

            var country = this.countries.All(c => c.Name == city.Country).FirstOrDefault();

            if (!uniqueCities.Contains(city.Name))
            {
                var newCity = new City()
                {
                    Name = city.Name,
                    Country = country
                };

                uniqueCities.Add(city.Name);
                this.cities.Add(newCity);
                this.unitOfWork.Commit();
            }

            var currentCity = this.cities.All(c => c.Name == city.Name).FirstOrDefault();
            return currentCity;
        }
    }
}
