using System.Data.Entity.Migrations;

namespace SuperHeroes.Data.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<SuperHeroesDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SuperHeroesDbContext context)
        {
        }
    }
}
