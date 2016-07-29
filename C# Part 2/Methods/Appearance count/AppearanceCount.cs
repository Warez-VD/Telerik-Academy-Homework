using System;
using System.Linq;

namespace AppearanceCount
{
    class AppearanceCount
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int[] array = Console.ReadLine()
                .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int X = int.Parse(Console.ReadLine());

            Console.WriteLine(FreqencyOfNumber(array, X)); 
        }
        
        public static int FreqencyOfNumber(int[] array, int x)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                {
                    count++;
                } 
            }

            return count;
        }
    }
}
