namespace AnimalHierarchy
{
    public class Kitten : Cat
    {
        private static string gender = "Female";

        public Kitten(string name, int age)
            : base(name, age, gender)
        {
        }
    }
}
