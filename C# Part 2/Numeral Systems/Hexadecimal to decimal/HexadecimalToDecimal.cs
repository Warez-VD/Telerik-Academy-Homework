using System;

namespace HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main()
        {
            string hexNum = Console.ReadLine();
            long decNum = 0;

            for (int i = 0, j = hexNum.Length - 1; i < hexNum.Length; i++, j--)
            {
                if (char.IsDigit(hexNum[j]))
                {
                    decNum += (hexNum[j] - '0') * (long)Math.Pow(16, i);
                }
                else if (char.IsUpper(hexNum[j]))
                {
                    decNum += ((hexNum[j] - 'A') + 10) * (long)Math.Pow(16, i);
                }
            }

            Console.WriteLine(decNum);
        }
    }
}
