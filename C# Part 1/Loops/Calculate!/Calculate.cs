using System;

class CalculateTheSumOfNandX
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double sum = 1;
        int nFactorial = 1;
        int i = 1;
        while (i <= n)
        {
            nFactorial = nFactorial * i;
            sum += (nFactorial / (Math.Pow(x, i)));
            i++;
        }
        Console.WriteLine("{0:F5}", sum);
    }
}