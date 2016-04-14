using System;

class SumOfNnumbers
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        if (1 <= n && n <= 200)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double numbers = double.Parse(Console.ReadLine());
                sum += numbers;
            }
            Console.WriteLine(sum);
        }
    }
}

