namespace School.Models
{
    using System;

    using Interfaces;

    public class Student : IStudent
    {
        private string name;
        private int uniqueNumber;
        private const string DefaultName = "Anonymous";
        private const int MinUniqueNumber = 10000;
        private const int MaxUniqueNumber = 99999;

        public Student()
            : this(DefaultName, MinUniqueNumber)
        {
        }

        public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.IsNotValidName(value);

                this.name = value;
            }
        }

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }
            private set
            {
                this.IsUniqueNumberOutOfRange(value);

                this.uniqueNumber = value;
            }
        }

        public void IsNotValidName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name cannot be empty");
            }
        }

        public void IsUniqueNumberOutOfRange(int uniqueNumber)
        {
            if (MinUniqueNumber > uniqueNumber || uniqueNumber > MaxUniqueNumber)
            {
                throw new ArgumentException(string.Format("Unique number must be between {0} and {1}", MinUniqueNumber, MaxUniqueNumber));
            }
        }
    }
}
