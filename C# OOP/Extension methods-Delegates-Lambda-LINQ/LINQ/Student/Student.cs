namespace LINQ.Students
{
    using System.Collections.Generic;

    public class Student
    {
        public Student(string firstName, string lastName, int age)
            : this(firstName, lastName, age, null, 0, null, null, 0)
        {
        }

        public Student(string firstName, string lastName, int age, string tel, int fNumber, string email, List<int> marks, int groupNum)   
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Tel = tel;
            this.FN = fNumber;
            this.Email = email;
            this.Marks = new List<int>();
            this.GroupNumber = groupNum;
        }

        #region Properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Tel { get; set; }

        public int FN { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; private set; }
        #endregion
        
        public void Add(int mark)
        {
            this.Marks.Add(mark);
        }
    }
}
