using System;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            string binary = Console.ReadLine();
            long result = 0;

            for (int i = 0, j = binary.Length - 1; i < binary.Length; i++, j--)
            {
                result += (binary[j] - '0') * (long)(Math.Pow(2, i));
            }

            Console.WriteLine(result);
        }
    }
}
