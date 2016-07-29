using System;
using System.Linq;

namespace IntegerCalculations
{
    class IntegerCalculations
    {
        static void Main()
        {
            int[] numbers = ReadArray();

            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Max());
            Console.WriteLine("{0:F2}", numbers.Average());
            Console.WriteLine(ArraySum(numbers));
            Console.WriteLine(ArrayProduct(numbers));
        }


        public static int ArraySum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        public static long ArrayProduct(int[] array)
        {
            long product = 1;

            for (int i = 0; i < array.Length; i++)
            {
                product *= (long)array[i];
            }

            return product;
        }

        public static int[] ReadArray()
        {
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            return array;
        }
    }
}
