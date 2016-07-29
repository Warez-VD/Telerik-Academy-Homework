using System;

namespace DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main()
        {
            long decNum = long.Parse(Console.ReadLine());
            string hexNum = string.Empty;

            while (decNum != 0)
            {
                long decDiv = decNum % 16;
                if (0 >= decDiv || decDiv < 10)
                {
                    hexNum = decDiv + hexNum;
                }
                else
                {
                    switch (decDiv)
                    {
                        case 10:
                            hexNum = 'A' + hexNum;
                            break;
                        case 11:
                            hexNum = 'B' + hexNum;
                            break;
                        case 12:
                            hexNum = 'C' + hexNum;
                            break;
                        case 13:
                            hexNum = 'D' + hexNum;
                            break;
                        case 14:
                            hexNum = 'E' + hexNum;
                            break;
                        case 15:
                            hexNum = 'F' + hexNum;
                            break;
                    }
                }
                decNum /= 16;

            }
            Console.WriteLine(hexNum);
        }
    }
}
