using System;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            long N = long.Parse(Console.ReadLine());
            string result = string.Empty;

            while (N != 0)
            {
                result = (N % 2).ToString() + result;
                N /= 2;
            }

            Console.WriteLine(result);
        }
    }
}
