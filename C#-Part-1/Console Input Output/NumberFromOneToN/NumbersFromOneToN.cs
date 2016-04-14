using System;

class NumbersFromOneToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (1 <= n && n <= 1000)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

