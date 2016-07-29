namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Ivan", "Petrov", 5),
                new Student("Angel", "Ivanov", 3),
                new Student("Stoqn", "Petkov", 5),
                new Student("Dragan", "Cvetkov", 2),
                new Student("George", "Vasilev", 6),
                new Student("Cvetan", "Ivelinov", 5),
                new Student("Ivana", "Ivanova", 4),
                new Student("Ana", "Petrova", 6),
                new Student("Vasil", "Vasilev", 2),
                new Student("Ivan", "Stefanov", 3)
            };

            var orderedStudents = students.OrderBy(x => x.Grade);

            Console.WriteLine("Students:");
            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student);
            }

            List<Worker> workers = new List<Worker>
            {
                new Worker("Ivan", "Petrov", 800, 8),
                new Worker("Angel", "Ivanov", 400, 6),
                new Worker("Stoqn", "Petkov", 500, 6),
                new Worker("Dragan", "Cvetkov", 2000, 10),
                new Worker("Gerasim", "Vasilev", 1500, 8),
                new Worker("Cvetan", "Ivelinov", 580, 6),
                new Worker("Kalina", "Ivanova", 800, 10),
                new Worker("Ana", "Petrova", 650, 10),
                new Worker("Vasil", "Vasilev", 1800, 8),
                new Worker("Vasilen", "Stefanov", 700, 10)
            };

            var newWorkers = workers
                .Select(x => new { FullName = x.FirstName + " " + x.LastName, Salary = x.MoneyPerHour() })
                .OrderByDescending(x => x.Salary);

            Console.WriteLine();
            Console.WriteLine("Workers:");
            foreach (var worker in newWorkers)
            {
                Console.WriteLine(worker.FullName + " " + worker.Salary);
            }

            Console.WriteLine();
            Console.WriteLine("Merged List");
            var mergedList = students.Select(st => new { st.FirstName, st.LastName })
                .Union(workers.Select(wk => new { wk.FirstName, wk.LastName }))
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName);

            foreach (var item in mergedList)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
        }
    }
}
