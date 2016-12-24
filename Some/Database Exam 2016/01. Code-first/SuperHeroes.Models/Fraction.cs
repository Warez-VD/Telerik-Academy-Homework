using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHeroes.Models
{
    public class Fraction
    {
        private ICollection<Planet> planets;
        private ICollection<Superhero> superHeroes;

        public Fraction()
        {
            this.planets = new HashSet<Planet>();
            this.superHeroes = new HashSet<Superhero>();
        }

        public int Id { get; set; }

        [Index]
        [MinLength(2)]
        [MaxLength(30)]
        public string Name { get; set; }

        public Alignment Alignment { get; set; }

        public virtual ICollection<Planet> Planets
        {
            get { return this.planets; }
            set { this.planets = value; }
        }

        public virtual ICollection<Superhero> SuperHeroes
        {
            get { return this.superHeroes; }
            set { this.superHeroes = value; }
        }
    }
}
