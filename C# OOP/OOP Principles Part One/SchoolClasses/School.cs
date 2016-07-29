namespace SchoolClasses
{
    using System.Collections.Generic;

    public class School
    {
        private List<SchoolClass> classesOfStuds;

        public School()
        {
            this.classesOfStuds = new List<SchoolClass>();
        }

        public List<SchoolClass> Classes
        {
            get
            {
                return new List<SchoolClass>(classesOfStuds);
            }
        }


        public void AddSchoolClass(SchoolClass newClass)
        {
            this.classesOfStuds.Add(newClass);
        }

        public void RemoveSchoolClass(SchoolClass currentClass)
        {
            this.classesOfStuds.Remove(currentClass);
        }
    }
}
