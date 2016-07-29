namespace LINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Students;

    public static class MethodsLINQ
    {
        public static IEnumerable<T> FirstBeforeLast<T>(this IEnumerable<T> array)
            where T : Student
        {
            var newArray = array
                .Where(x => x.FirstName.CompareTo(x.LastName) == -1)
                .ToArray();

            return newArray;
        }
        
        public static IEnumerable<T> AgeRange<T>(this IEnumerable<T> array)
            where T : Student
        {
            var newArray = array
                .Where(x => x.Age > 17 && x.Age < 25)
                .ToArray();

            return newArray;
        }

        public static IEnumerable<T> Order<T>(this IEnumerable<T> array)
            where T : Student
        {
            var newArray = array
                .OrderByDescending(x => x.FirstName)
                .ThenByDescending(x => x.LastName)
                .ToArray();

            return newArray;
        }

        public static int[] Divisible(this IEnumerable<int> collection)
        {
            var newCollection = collection
                .Where(x => x % 7 == 0 && x % 3 == 0)
                .ToArray();

            return newCollection;
        }


        public static IEnumerable<T> GroupStudents<T>(this IEnumerable<T> studentsList, int group)
            where T : Student
        {
            var result = studentsList
                .Where(x => x.GroupNumber == group)
                .ToList();

            return result;
        }

        public static IEnumerable<T> GroupByEmail<T>(this IEnumerable<T> studentsList, string emailDomainName)
            where T : Student
        {
            var result = studentsList
                .Where(e => e.Email.Contains(emailDomainName))
                .ToList();

            return result;
        }

        public static IEnumerable<T> GroupByPhone<T>(this IEnumerable<T> studentsList, string pattern)
            where T : Student
        {
            var newCollection = studentsList
                .Where(x => x.Tel.Substring(0, pattern.Length) == pattern)
                .ToList();

            return newCollection;
        }

        public static IEnumerable<T> ExtractStudentWith2<T>(this IEnumerable<T> studentsList, int mark)
            where T : Student
        {
            var badStudents = new List<T>();

            bool isBad = false;
            foreach (var item in studentsList)
            {
                foreach (var it in item.Marks)
                {
                    if (it == mark)
                    {
                        isBad = true;
                    }
                }

                if (isBad)
                {
                    badStudents.Add(item);
                    isBad = false;
                }
            }

            return badStudents;
        }

        public static IEnumerable<T> ExtractStudentsFromYear<T>(this IEnumerable<T> studentsList, string yearNumber)
            where T : Student
        {
            var markCollection = studentsList
                .Where(x => x.FN.ToString().Substring(4, 2) == yearNumber)
                .Select(x => x)
                .ToList();

            return markCollection;
        }

        public static int MaximumLenght(this string[] currentString)
        {
            var result = currentString
                .Select(x => x.Length)
                .Max();
            
            return result;
        }

        public static void GroupByGroupNumber<T>(this IEnumerable<T> studentsList)
            where T : Student
        {
            var groupedCollection = studentsList
                .GroupBy(x => x.GroupNumber);

            foreach (var group in groupedCollection)
            {
                Console.WriteLine("Group " + group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine($"{item.FirstName} {item.LastName}");
                }
            }
        }
    }
}
