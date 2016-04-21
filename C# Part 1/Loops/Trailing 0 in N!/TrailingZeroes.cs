using System;

class TrailingZeroes
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int counter = 1;
        int zeroes = 0;
        while (true)
        {
            zeroes += number / (int)Math.Pow(5, counter);
            counter++;
            if (Math.Pow(5, counter) > number)
            {
                break;
            }
        }
        Console.WriteLine(zeroes);
    }
}

