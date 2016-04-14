using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchange
{
    class BitExchange
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            long mask;
            long maskTwo;
            long result;
            long resultTwo;
            uint dynamicNum = number;
            int secondPosition = 24;
            for (int i = 0, j = 3; i <= 2; i++, j++)
            {
                mask = 1 << j;
                long iAndMask = mask & dynamicNum;
                long bit = iAndMask >> j;

                maskTwo = 1 << secondPosition;
                iAndMask = maskTwo & dynamicNum;
                long bitTwo = iAndMask >> secondPosition;

                long temp = bit;
                bit = bitTwo;
                bitTwo = temp;

                if (bit == 0)
                {
                    mask = ~(1 << j);
                    result = mask & dynamicNum;
                }
                else
                {
                    mask = 1 << j;
                    result = mask | dynamicNum;
                }
                if (bitTwo == 0)
                {
                    mask = ~(1 << secondPosition);
                    resultTwo = mask & result;
                    dynamicNum = (uint)resultTwo;
                    if (i == 2)
                    {
                        Console.WriteLine(resultTwo);
                    }
                }
                else
                {
                    mask = 1 << secondPosition;
                    resultTwo = mask | result;
                    dynamicNum = (uint)resultTwo;
                    if (i == 2)
                    {
                        Console.WriteLine(resultTwo);
                    }
                }
                secondPosition++;
            }
        }
    }
}
