using System;

class MinMaxSumAverage
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double min = int.MaxValue;
        double max = int.MinValue;
        double average;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            double newMin = number;
            double newMax = number;
            sum += number;
            if (newMin < min)
            {
                min = number;
            }
            if (newMax > max)
            {
                max = number;
            }
        }
        average = sum / n;
        Console.WriteLine("min={0:0.00}", min);
        Console.WriteLine("max={0:0.00}", max);
        Console.WriteLine("sum={0:0.00}", sum);
        Console.WriteLine("avg={0:0.00}", average);
    }
}

