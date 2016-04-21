using System;
using System.Numerics;

class BinaryToDecimal
{
    static void Main()
    {
        string binary = Console.ReadLine();
        BigInteger decNumber = BigInteger.Parse(binary);
        BigInteger number = decNumber;
        long sum = 0;
        int counter = 0;
        for (int i = binary.Length; i > 0; i--)
        {
            BigInteger currentNum = number % 10;
            sum += (long)currentNum * (long)Math.Pow(2, counter);
            number /= 10;
            counter++;
            if (number == 0)
            {
                break;
            }
        }
        Console.WriteLine(sum);
    }
}

