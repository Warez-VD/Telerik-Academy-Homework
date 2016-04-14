using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitSwap
{
    class BitSwap
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long mask;
            long maskTwo;
            long result;
            long resultTwo;
            uint dynamicNum = n;
            int secondPosition = q;
            for (int i = 0, j = p; i < k; i++, j++)
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
                    if (i == k - 1)
                    {
                        Console.WriteLine(resultTwo);
                    }
                }
                else
                {
                    mask = 1 << secondPosition;
                    resultTwo = mask | result;
                    dynamicNum = (uint)resultTwo;
                    if (i == k - 1)
                    {
                        Console.WriteLine(resultTwo);
                    }
                }
                secondPosition++;
            }
        }
    }
}
