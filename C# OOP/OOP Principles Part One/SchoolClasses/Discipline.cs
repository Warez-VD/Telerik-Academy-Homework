namespace SchoolClasses
{
    public class Discipline : IName, IComment
    {
        public Discipline(string name, int numOfLectures, int numOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numOfLectures;
            this.NumberOfExercises = numOfExercises;
        }

        public Discipline(string name, int numOfLectures, int numOfExercises, string comment)
            : this(name, numOfLectures, numOfExercises)
        {
            this.Comment = comment;
        }
        
        public string Name { get; private set; }

        public int NumberOfLectures { get; private set; }

        public int NumberOfExercises { get; private set; }

        public string Comment { get; set; }
    }
}
