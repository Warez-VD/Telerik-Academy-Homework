namespace SchoolClasses
{
    public class Student : People, IComment, IName
    {
        public Student(string name, int classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public Student(string name, int classNumber, string comment)
            : this(name, classNumber)
        {
            this.Comment = comment;
        }

        public int ClassNumber { get; private set; }

        public string Comment { get; set; }
    }
}
