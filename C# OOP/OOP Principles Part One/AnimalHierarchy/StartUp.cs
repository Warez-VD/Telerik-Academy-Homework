namespace AnimalHierarchy
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            Animal[] animals = new Animal[]
            {
                new Cat("Harry", 2, "Male"),
                new Kitten("John", 3),
                new Dog("Pepe", 5, "Female"),
                new Cat("Ludmil", 10, "Male"),
                new Frog("Jabok", 3, "Female"),
                new Frog("Zelen", 8, "Male")
            };

            var groupedByType = animals
                .GroupBy(x => x.GetType().Name)
                .ToList();

            foreach (var animalType in groupedByType)
            {
                var average = animalType.Average(x => x.Age);
                Console.WriteLine($"Average age for {animalType.Key}: {average}");
            }
        }
    }
}
