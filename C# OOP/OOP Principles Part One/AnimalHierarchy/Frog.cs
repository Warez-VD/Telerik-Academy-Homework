namespace AnimalHierarchy
{
    using System;

    public class Frog : Animal
    {
        public Frog(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Kvak-kvak");
        }
    }
}
