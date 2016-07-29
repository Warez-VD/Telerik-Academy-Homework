using System;
using System.Linq;

namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int[] array = Console.ReadLine()
                .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            Console.WriteLine(LargerThanOthers(array));
        }


        public static int LargerThanOthers(int[] array)
        {
            int counter = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1] && array[i] > array[i - 1])
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
