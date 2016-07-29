namespace StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                if (grade < 2 && grade > 6)
                {
                    throw new ArgumentException("Invalid grade was setted");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return $"{base.FirstName} {base.LastName} {this.Grade}";
        }
    }
}
