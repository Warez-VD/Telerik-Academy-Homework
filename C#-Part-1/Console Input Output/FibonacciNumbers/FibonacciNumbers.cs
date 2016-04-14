using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (1 <= n && n <= 50)
        {
            long firstMember = 0;
            long secondMember = 1;
            if (n == 1)
            {
                Console.WriteLine(firstMember);
            }
            else if (n == 2)
            {
                Console.Write("{0}, {1}", firstMember, secondMember);
                Console.WriteLine();
            }
            if (n > 2)
            {
                Console.Write("{0}, {1}, ", firstMember, secondMember);
                for (int i = 2; i < n; i++)
                {
                    long nextMember = firstMember + secondMember;
                    if (i < n - 1)
                    {
                        Console.Write("{0}, ", nextMember);
                    }
                    else
                    {
                        Console.Write("{0}", nextMember);
                    }
                    firstMember = secondMember;
                    secondMember = nextMember;
                }
            }
        }
    }
}

