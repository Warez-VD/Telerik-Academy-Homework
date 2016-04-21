using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (0 <= n && n <= 100)
        {
            int firstLine = 2 * n;
            BigInteger factorialTwoN = 1;
            int counter = 1;
            BigInteger catNumber = 0;
            BigInteger factorialPlusOne = 1;
            BigInteger factorialN = 1;
            while (counter <= firstLine)
            {
                factorialTwoN *= counter;
                if (counter <= n + 1)
                {
                    factorialPlusOne *= counter;
                }
                if (counter <= n)
                {
                    factorialN *= counter;
                }
                counter++;
            }
            catNumber = factorialTwoN / (factorialPlusOne * factorialN);
            Console.WriteLine(catNumber);
        }
    }
}

