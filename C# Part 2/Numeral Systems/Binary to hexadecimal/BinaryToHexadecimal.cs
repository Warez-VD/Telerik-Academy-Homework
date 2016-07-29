using System;
using System.Numerics;

namespace BinaryToHexadecimal
{
    class BinaryToHexadecimal
    {
        static void Main()
        {
            string binary = Console.ReadLine();
            BigInteger decNum = BinaryToDecimal(binary);
            DecimalToHexadecimal(decNum);
        }


        public static BigInteger BinaryToDecimal(string binary)
        {
            BigInteger sum = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                sum = (binary[i] - '0') + sum * 2;
            }

            return sum;
        }


        public static void DecimalToHexadecimal(BigInteger number)
        {
            string hexNum = string.Empty;

            while (number != 0)
            {
                BigInteger decDiv = number % 16;
                string forSwitch = decDiv.ToString();
                if (0 >= decDiv || decDiv < 10)
                {
                    hexNum = decDiv + hexNum;
                }
                else
                {
                    switch (forSwitch)
                    {
                        case "10":
                            hexNum = 'A' + hexNum;
                            break;
                        case "11":
                            hexNum = 'B' + hexNum;
                            break;
                        case "12":
                            hexNum = 'C' + hexNum;
                            break;
                        case "13":
                            hexNum = 'D' + hexNum;
                            break;
                        case "14":
                            hexNum = 'E' + hexNum;
                            break;
                        case "15":
                            hexNum = 'F' + hexNum;
                            break;
                    }
                }
                number /= 16;
            }

            Console.WriteLine(hexNum);
        }
    }
}
