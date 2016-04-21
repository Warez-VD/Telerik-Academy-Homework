using System;
using System.Numerics;

class CalculateThree
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint k = uint.Parse(Console.ReadLine());
        BigInteger sum = 0;
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialNmK = 1;
        int counter = 1;
        uint NmK = n - k;
        if (1 <= k && k <= n && n <= 100)
        {
            while (counter <= n)
            {
                factorialN *= counter;
                if (counter <= k)
                {
                    factorialK *= counter;
                }
                if (counter <= NmK)
                {
                    factorialNmK *= counter;
                }
                counter++;
            }
            sum = factorialN / (factorialK * factorialNmK);
            Console.WriteLine(sum);
        }
    }
}

