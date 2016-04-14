using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        int sum = 0;
        for (int i = 0; i < 5; i++)
        {
            int numbers = int.Parse(Console.ReadLine());
            sum += numbers;
        }
        Console.WriteLine(sum);
    }
}

