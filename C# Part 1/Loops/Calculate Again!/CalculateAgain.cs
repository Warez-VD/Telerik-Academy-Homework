using System;
using System.Numerics;

class CalculateAgain
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        int counter = 1;
        BigInteger sum = 0;
        if (1 < k && k < n && n < 100)
        {
            while (counter <= n)
            {
                factorialN *= counter;
                if (counter <= k)
                {
                    factorialK *= counter;
                }
                counter++;
            }
            sum = factorialN / factorialK;
        }
        Console.WriteLine(sum);
    }
}

