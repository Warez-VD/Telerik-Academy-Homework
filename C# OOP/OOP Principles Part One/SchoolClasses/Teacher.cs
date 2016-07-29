namespace SchoolClasses
{
    using System.Collections.Generic;

    public class Teacher : People, IName, IComment
    {
        private List<Discipline> disciplineSet;

        public Teacher(string name)
            : base(name)
        {
            this.disciplineSet = new List<Discipline>();
        }

        public Teacher(string name, string comment)
            : this(name)
        {
            this.Comment = comment;
        }

        public string Comment { get; set; }

        public List<Discipline> Disciplines
        {
            get
            {
                return new List<Discipline>(disciplineSet);
            }
        }

        public void AddDiscipline(Discipline newDiscipline)
        {
            this.disciplineSet.Add(newDiscipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.disciplineSet.Remove(discipline);
        }
    }
}
