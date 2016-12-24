namespace SuperHeroes.Models
{
    public class SuperheroRelations
    {
        public int Id { get; set; }

        public int FirstSuperheroId { get; set; }

        public virtual Superhero FirstSuperhero { get; set; }

        public int SecondSuperheroId { get; set; }

        public virtual Superhero SecondSuperhero { get; set; }

        public RelationshipType Relationship { get; set; }
    }
}
