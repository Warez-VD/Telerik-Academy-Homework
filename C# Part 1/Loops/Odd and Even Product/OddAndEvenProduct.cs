using System;
using System.Numerics;

class OddAndEvenProduct
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (4 <= n && n <= 50)
        {
            BigInteger even = 1;
            BigInteger odd = 1;
            string[] numbers = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            bool equal;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    odd *= int.Parse(numbers[i]);
                }
                else if (i % 2 != 0)
                {
                    even *= int.Parse(numbers[i]);
                }
            }
            equal = even == odd;
            if (equal)
            {
                Console.WriteLine("yes {0}", even);
            }
            else
            {
                Console.WriteLine("no {0} {1}", odd, even);
            }
        }
    }
}

