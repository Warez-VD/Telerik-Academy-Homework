using System;
using System.Linq;

namespace SortingArray
{
    class SortingArray
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = ReadMatrix();
            Array.Sort(arr);
            Console.WriteLine(string.Join(" ", arr).TrimEnd(' '));

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
