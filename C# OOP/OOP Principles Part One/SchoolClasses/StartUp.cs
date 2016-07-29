namespace SchoolClasses
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            var school = new School();
            school.AddSchoolClass(new SchoolClass("2A"));
            school.AddSchoolClass(new SchoolClass("3G"));
            SchoolClass clas = new SchoolClass("4A");
            clas.AddTeacher(new Teacher("Ivan Penchev"));
            clas.AddStudent(new Student("Valeri Velinov", 5));
            Console.WriteLine(clas.ClassIdentifier);
            school.Classes.Clear();
            Console.WriteLine(school.Classes);
        }
    }
}
