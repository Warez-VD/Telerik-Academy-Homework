using System;
using System.Linq;
using System.Text;

namespace NumberAsArray
{
    class NumberAsArray
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, ',', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int sizeOne = input[0];
            int sizeTwo = input[1];
            string[] arrOne = ReadArray();
            string[] arrTwo = ReadArray();
            Array.Reverse(arrOne);
            Array.Reverse(arrTwo);
            string first = AssignString(arrOne);
            string second = AssignString(arrTwo);

            int sum = int.Parse(first) + int.Parse(second);
            first = sum.ToString();
            
            StringBuilder result = new StringBuilder();

            for (int i = first.Length - 1; i >= 0; i--)
            {
                result.Append(first[i]);
            }

            string newResult = result.ToString();

            for (int i = 0; i < newResult.Length; i++)
            {
                Console.Write(newResult[i] + " ");
            }
        }


        public static string AssignString(string[] arr)
        {
            StringBuilder build = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                build.Append(arr[i]);
            }

            return build.ToString();
        }

        public static string[] ReadArray()
        {
            string[] array = Console.ReadLine()
                    .Split(new char[] { ' ', '\t' }, ',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x)
                    .ToArray();

            return array;
        }
    }
}
