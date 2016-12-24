using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHeroes.Models
{
    public class Superhero
    {
        private ICollection<Power> powers;
        private ICollection<Fraction> fractions;

        public Superhero()
        {
            this.powers = new HashSet<Power>();
            this.fractions = new HashSet<Fraction>();
        }

        public int Id { get; set; }

        [MinLength(3)]
        [MaxLength(60)]
        public string Name { get; set; }

        [Index]
        [MinLength(3)]
        [MaxLength(20)]
        public string SecretIdentity { get; set; }

        public Alignment Alignment { get; set; }

        [MinLength(1)]
        public string Story { get; set; }

        public virtual ICollection<Power> Powers
        {
            get { return this.powers; }
            set { this.powers = value; }
        }

        public int CityId { get; set; }

        public virtual City City { get; set; }

        public virtual ICollection<Fraction> Fractions
        {
            get { return this.fractions; }
            set { this.fractions = value; }
        }
    }
}
