using System.Data.Entity;
using SuperHeroes.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SuperHeroes.Data
{
    public class SuperHeroesDbContext : DbContext
    {
        public SuperHeroesDbContext()
            : base("SuperHeroesDB")
        {
        }

        public DbSet<Superhero> Superheroes { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Fraction> Fractions { get; set; }

        public DbSet<Planet> Planets { get; set; }

        public DbSet<Power> Powers { get; set; }

        public DbSet<SuperheroRelations> Relationships { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
