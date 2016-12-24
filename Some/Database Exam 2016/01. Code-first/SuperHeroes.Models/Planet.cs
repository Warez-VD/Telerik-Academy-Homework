using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHeroes.Models
{
    public class Planet
    {
        public int Id { get; set; }
        
        [Index]
        [MinLength(2)]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
