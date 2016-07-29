using System;
using System.Numerics;

namespace Factorial
{
    class Factorial
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(FindFactorial(N));
        }


        public static BigInteger FindFactorial(int number)
        {
            BigInteger factorial = 1;

            while (number != 0)
            {
                factorial *= number;
                number--;
            }

            return factorial;
        }
    }
}
