using System;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void Main()
        {
            string num = Console.ReadLine();
            string reversed = string.Empty;
            for (int i = num.Length - 1; i >= 0; i--)
            {
                reversed += num[i];
            }
            Console.WriteLine(reversed);
        }
    }
}
