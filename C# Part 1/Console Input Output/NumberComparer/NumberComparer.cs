using System;

class NumberComparer
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double result = Math.Max(a, b);
        Console.WriteLine(result);
    }
}

