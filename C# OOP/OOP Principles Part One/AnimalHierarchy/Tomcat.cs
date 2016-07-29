namespace AnimalHierarchy
{
    public class Tomcat : Cat
    {
        private static string gender = "Male";

        public Tomcat(string name, int age)
            : base(name, age, gender)
        {
        }
    }
}
