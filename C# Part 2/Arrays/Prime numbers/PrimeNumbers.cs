using System;
using System.Collections.Generic;

class PrimeNumbers
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        bool[] isPrime = new bool[N + 1];
        List<int> primeNums = new List<int>();

        for (int i = 2; i <= N; i++)
        {
            isPrime[i] = true;
        }

        for (int i = 2; i <= N; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * 2; j <= N; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        for (int i = 2; i <= N; i++)
        {
            if (isPrime[i] == true)
            {
                primeNums.Add(i);
            }
        }

        var biggestPrimeNum = primeNums[primeNums.Count - 1];
        Console.WriteLine(biggestPrimeNum);
    }
}

