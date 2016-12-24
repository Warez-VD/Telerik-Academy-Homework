using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHeroes.Models
{
    public class Country
    {
        public int Id { get; set; }

        [Index]
        [MinLength(2)]
        [MaxLength(30)]
        public string Name { get; set; }

        public int PlanetId { get; set; }

        public Planet Planet { get; set; }
    }
}
