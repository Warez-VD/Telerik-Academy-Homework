using System;

class ExchangeNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double min, max;
        if (a > b)
        {
            min = b;
            max = a;
            Console.WriteLine("{0} {1}", min, max);
        }
        else
        {
            min = a;
            max = b;
            Console.WriteLine("{0} {1}", min, max);
        }
    }
}

