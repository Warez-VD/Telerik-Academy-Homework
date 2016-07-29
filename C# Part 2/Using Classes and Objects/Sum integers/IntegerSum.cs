using System;
using System.Linq;

namespace IntegerSum
{
    class IntegerSum
    {
        static void Main()
        {
            int[] numbers = ReadArray();
            Sum(numbers);
        }


        public static int[] ReadArray()
        {
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            return array;
        }


        public static void Sum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Console.WriteLine(sum);
        }

    }
}
