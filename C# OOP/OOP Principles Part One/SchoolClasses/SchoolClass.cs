namespace SchoolClasses
{
    using System.Collections.Generic;

    public class SchoolClass : IComment
    {
        private List<Teacher> teachersSet;
        private List<Student> studentSet;

        public SchoolClass(string textIdentifier)
        {
            this.ClassIdentifier = textIdentifier;
            this.teachersSet = new List<Teacher>();
            this.studentSet = new List<Student>();
        }

        public SchoolClass(string textIdentifier, string comment)
            : this (textIdentifier)
        {
            this.Comment = comment;
        }

        public string ClassIdentifier { get; private set; }

        public List<Teacher> Teachers
        {
            get
            {
                return new List<Teacher>(teachersSet);
            }
        }

        public List<Student> Students
        {
            get
            {
                return new List<Student>(studentSet);
            }
        }

        public string Comment { get; set; }

        public void AddTeacher(Teacher newTeacher)
        {
            this.teachersSet.Add(newTeacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.teachersSet.Remove(teacher);
        }

        public void AddStudent(Student newStudent)
        {
            this.studentSet.Add(newStudent);
        }

        public void RemoveStudent(Student student)
        {
            this.studentSet.Remove(student);
        }
    }
}
