using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHeroes.Models
{
    public class Power
    {
        public int Id { get; set; }

        [Index]
        [MinLength(3)]
        [MaxLength(35)]
        public string Name { get; set; }
    }
}
