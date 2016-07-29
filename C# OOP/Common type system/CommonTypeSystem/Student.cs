namespace CommonTypeSystem
{
    using System;
    using System.Text;

    using Enumerations;
    
    public class Student : ICloneable, IComparable<Student>
    {
        private SpecialtyType specialty;
        private UniversityType university;
        private FacultyType faculty;

        public Student(string firstName, string midName, string lastName, int ssn)
        {
            this.FirstName = firstName;
            this.MiddleName = midName;
            this.LastName = lastName;
            this.SSN = ssn;
        }

        public Student(string firstName, string midName, string lastName, int ssn, string address,
                        string phone, string email, string course)
                       : this(firstName, midName, lastName, ssn)
        {
            this.Address = address;
            this.MobilePhone = phone;
            this.Email = email;
            this.Course = course;
        }

        public Student(string firstName, string midName, string lastName, int ssn,
                        string address, string phone, string email, string course,
                        SpecialtyType specialty, UniversityType university, FacultyType faculty)
                      : this(firstName, midName, lastName, ssn, address, phone, email, course)
        {
            this.specialty = specialty;
            this.university = university;
            this.faculty = faculty;
        }

        public string FirstName { get; private set; }

        public string MiddleName { get; private set; }

        public string LastName { get; private set; }

        public int SSN { get; private set; }

        public string Address { get; private set; }

        public string MobilePhone { get; private set; }

        public string Email { get; set; }

        public string Course { get; private set; }

        public SpecialtyType Specialty
        {
            get { return this.specialty; }
        }

        public UniversityType University
        {
            get { return this.university; }
        }

        public FacultyType Faculty
        {
            get { return this.faculty; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Student stud = obj as Student;
            if ((Object)stud == null)
            {
                return false;
            }

            return FirstName == stud.FirstName && LastName == stud.LastName;
        }

        public override int GetHashCode()
        {
            int hash = SSN.GetHashCode();
            return 31 * hash;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"Name: {this.FirstName} {this.MiddleName} {this.LastName}");
            builder.AppendLine($"Social number: {this.SSN}");
            builder.AppendLine($"Address: {this.Address}");
            builder.AppendLine($"Phone number: {this.MobilePhone}");
            builder.AppendLine($"Email: {this.Email}");
            builder.AppendLine($"Course: {this.Course}");
            builder.AppendLine($"University: {this.University}");
            builder.AppendLine($"Faculty: {this.Faculty}");
            builder.AppendLine($"Specialty: {this.Specialty}");

            return builder.ToString();
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN,
                this.Address, this.MobilePhone, this.Email, this.Course);
        }

        public int CompareTo(Student otherStudent)
        {
            if (this.FirstName == otherStudent.FirstName)
            {
                return this.SSN.CompareTo(otherStudent.SSN);
            }

            return this.FirstName.CompareTo(otherStudent.FirstName);
        }

        public static bool operator ==(Student stud1, Student stud2)
        {
            if (stud1.FirstName == stud2.FirstName &&
                stud1.MiddleName == stud2.MiddleName &&
                stud1.LastName == stud2.LastName)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Student stud1, Student stud2)
        {
            if (stud1.FirstName != stud2.FirstName ||
                stud1.MiddleName != stud2.MiddleName ||
                stud1.LastName != stud2.LastName)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
