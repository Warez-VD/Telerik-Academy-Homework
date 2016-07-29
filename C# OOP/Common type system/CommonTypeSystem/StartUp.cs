namespace CommonTypeSystem
{
    using System;
    using System.Text;

    using Enumerations;

    public class StartUp
    {
        //Binary search tree Task missing!

        public static void Main()
        {
            Console.WriteLine("Student Class Task");
            var student = new Student("Ivan", "Vasilev", "Ivanov", 124, "Sofia",
                                        "+359888688554", "gmail.com", "OOP",
                                        SpecialtyType.InformationTechnology,
                                        UniversityType.NBU, FacultyType.Mathematics);

            var studentTwo = (Student)student.Clone();
            studentTwo.Email = "abv.bg";


            Console.WriteLine($"Cloned student email: {studentTwo.Email}");
            Console.WriteLine($"First student email: {student.Email}");
            Console.WriteLine();

            Console.WriteLine("Person Class Task");
            var person = new Person("John");
            Console.WriteLine(person);

            Console.WriteLine("BitArray Task");
            var bitArray = new BitArray(152144);
            var otherBitArray = new BitArray(152144);
            var andAnotherBitArray = new BitArray(12312);

            Console.WriteLine(bitArray == otherBitArray);
            Console.WriteLine(bitArray == andAnotherBitArray);

            var arrayValues = new StringBuilder();
            foreach (var bit in bitArray)
            {
                arrayValues.Append(bit);
            }
            Console.WriteLine(arrayValues);
            Console.WriteLine(bitArray[59]);
            Console.WriteLine(bitArray[55]);
            
        }
    }
}
