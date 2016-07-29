namespace CommonTypeSystem
{
    using System.Text;

    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int age)
            : this(name)
        {
            this.Age = age;
        }

        public string Name { get; private set; }

        public int? Age { get; private set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"Name: {this.Name}");
            builder.AppendLine(string.Format("Age: {0}", this.Age == null ? "Not specified" : this.Age.ToString()));

            return builder.ToString();
        }
    }
}
