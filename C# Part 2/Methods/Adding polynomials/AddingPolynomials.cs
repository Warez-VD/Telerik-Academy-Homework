using System;
using System.Linq;

namespace AddingPolynomials
{
    class AddingPolynomials
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] firstArr = ReadMatrix();
            int[] secondArr = ReadMatrix();

            Console.WriteLine(string.Join(" ", SumPolynom(firstArr, secondArr, N)).TrimEnd(' '));
        }


        public static int[] SumPolynom(int[] arrOne, int[] arrTwo, int size)
        {
            int[] result = new int[size];

            for (int i = 0; i < arrOne.Length; i++)
            {
                result[i] = arrOne[i] + arrTwo[i];
            }

            return result;
        }

        public static int[] ReadMatrix()
        {
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            return array;
        }
    }
}
