namespace AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = gender;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Sex { get; private set; }

        public abstract void MakeSound();
    }
}
