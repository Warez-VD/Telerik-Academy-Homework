using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double discriminant = Math.Sqrt(Math.Pow(b, 2) - (4 * a * c));
        if (discriminant > 0)
        {
            double rootOne = (-b + discriminant) / (2 * a);
            double rootTwo = (-b - discriminant) / (2 * a);
            Console.WriteLine("{0:0.00}", Math.Min(rootOne, rootTwo));
            Console.WriteLine("{0:0.00}", Math.Max(rootOne, rootTwo));
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine("{0:0.00}", root);
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }
}

