namespace LINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Group;
    using MyTimer;
    using Students;

    public class MainProgram
    {
        static void Main()
        {
            //Without taks 20!

            //Task 3
            var students = new Student[]
                {
                new Student("Pesho", "Peshov", 18),
                new Student("Ivan", "Geshov", 40),
                new Student("Stefan", "Popov", 23),
                new Student("Ivan", "Peshov", 22)
                };
            Console.WriteLine("Task 3");
            var result = students.FirstBeforeLast();

            foreach (var item in result)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            Console.WriteLine();

            //Task 4
            Console.WriteLine("Task 4");
            var studentsAge = students.AgeRange();
            foreach (var item in studentsAge)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            Console.WriteLine();

            //Task 5
            Console.WriteLine("Task 5");
            var orderedStudents = students.Order();
            foreach (var item in orderedStudents)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            Console.WriteLine();

            //Task 6
            Console.WriteLine("Task 6");
            var array = new int[] { 1, 21, 3, 15, 23 };
            array = array.Divisible();
            foreach (var number in array)
            {
                Console.WriteLine("Is divisible by 7 and 3: " + number);
            }

            Console.WriteLine();

            //Task 7
            //Console.WriteLine("Task 7");
            //Timer timer = new Timer(5);
            //timer.InvokeAgain();

            //Task 8
            //Console.WriteLine("Task 8");
            //Timer time = new Timer(5);
            //Subscriber sub1 = new Subscriber("Sub1", time);
            //Subscriber sub2 = new Subscriber("Sub2", time);
            //time.InvokeAgain();

            //Task 9 - 10
            var otherStudents = new List<Student>()
            {
                new Student("Pesho", "Peshov", 18, "+359888666111", 121206343, "abv.bg", new List<int>(), 1),
                new Student("Ivan", "Geshov", 40, "+359888213611", 140205432, "gmail.com", new List<int>(), 3),
                new Student("Stefan", "Popov", 23, "+3598128226111", 12010634, "abv.bg", new List<int>(), 2),
                new Student("Ivan", "Peshov", 22, "+3598886612311", 12010823, "abv.bg", new List<int>(), 1)
            };
            
            //Adding marks
            otherStudents[0].Add(2);
            otherStudents[0].Add(6);
            otherStudents[1].Add(3);
            otherStudents[1].Add(4);
            otherStudents[1].Add(3);
            otherStudents[2].Add(2);
            otherStudents[2].Add(3);
            otherStudents[2].Add(6);
            otherStudents[3].Add(2);
            otherStudents[3].Add(2);
            otherStudents[3].Add(3);

            Console.WriteLine("Task 9 - 10");
            var studsByGroup = otherStudents
                .GroupStudents(2)
                .OrderBy(x => x.FirstName)
                .ToList();

            //Do the same with extension methods
            //If you try it first comment the above studsByGroup
            //var studsByGroup = otherStudents
            //    .Where(x => x.GroupNumber == 2)
            //    .OrderBy(x => x.FirstName)
            //    .ToList();

            foreach (var item in studsByGroup)
            {
                Console.WriteLine(string.Format($"{item.FirstName} {item.LastName} : from group {item.GroupNumber}"));
            }

            Console.WriteLine();

            //Task 11
            Console.WriteLine("Task 11");
            otherStudents
                .GroupByEmail("abv")
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName} contains the searched email: {x.Email}"));

            otherStudents
                .Where(x => x.Email.Contains("abv"))
                .Select(x => $"{x.FirstName} {x.LastName} contains the searched email: {x.Email}")
                .ToList()
                .ForEach(x => Console.WriteLine(x));

            Console.WriteLine();

            //Task 12
            //Selecting phone numbers by country code
            Console.WriteLine("Task 12");
            var studsByPhone = otherStudents
                .GroupByPhone("+359")
                .ToList();

            foreach (var student in studsByPhone)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            Console.WriteLine();

            //Task 13
            Console.WriteLine("Task 13");
            var exellentStuds = otherStudents
                .Where(x => x.Marks.Contains(6))
                .ToList();

            var anonymous = new
            {
                FullName = exellentStuds.Select(x => x.FirstName + " " + x.LastName),
                Marks = exellentStuds.Select(x => x.Marks)
            };

            foreach (var studentName in anonymous.FullName)
            {
                Console.WriteLine(studentName);
            }

            Console.WriteLine();

            //Task 14
            Console.WriteLine("Task 14");
            var badStudents = otherStudents
                .ExtractStudentWith2(2);
            foreach (var student in badStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} : Marks: {string.Join(" ", student.Marks)}");
            }

            Console.WriteLine();

            //Task 15
            Console.WriteLine("Task 15");
            var markCollection = otherStudents.ExtractStudentsFromYear("06");
            foreach (var mark in markCollection)
            {
                Console.WriteLine($"Marks: {string.Join(" ", mark.Marks)}");
            }

            Console.WriteLine();

            //Task 16
            var groups = new List<Groups>()
            {
                new Groups(1, "Mathematics"),
                new Groups(2, "Biology"),
                new Groups(3, "English")
            };

            Console.WriteLine("Task 16");

            var studentsByDepartment = otherStudents
                 .Join(groups,
                     st => st.GroupNumber,
                     gr => gr.GroupNumber,
                     (st, gr) => new { Name = st.FirstName + " " + st.LastName, gr.DepartmentName })
                  .Where(x => x.DepartmentName == "Mathematics");

            foreach (var student in studentsByDepartment)
            {
                Console.WriteLine($"{student.Name} - {student.DepartmentName}");
            }

            Console.WriteLine();

            //Task 17
            Console.WriteLine("Task 17");
            var text = new string[] { "hello", "CSharp", "OOP" };
            Console.WriteLine(text.MaximumLenght());

            Console.WriteLine();

            //Task 18 - 19
            //using Linq
            Console.WriteLine("Task 18");
            var groupNumCollection = otherStudents
                .GroupBy(gr => gr.GroupNumber);

            foreach (var group in groupNumCollection)
            {
                Console.WriteLine("Group " + group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine($"{item.FirstName} {item.LastName}");
                }
            }

            Console.WriteLine();

            //using Extension method
            Console.WriteLine("Task 19");
            var groupedCollection = otherStudents;
            groupedCollection.GroupByGroupNumber();
        }
    }
}
