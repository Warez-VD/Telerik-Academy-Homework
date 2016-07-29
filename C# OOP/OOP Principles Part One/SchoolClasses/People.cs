namespace SchoolClasses
{
    public abstract class People : IName
    {
        public People(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
    }
}
