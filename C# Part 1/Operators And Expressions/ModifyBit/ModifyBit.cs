using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBit
{
    class ModifyBit
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            short position = short.Parse(Console.ReadLine());
            byte value = byte.Parse(Console.ReadLine());
            if (value == 0)
            {
                ulong mask = ~((ulong)1 << position);
                ulong result = mask & number;
                Console.WriteLine(result);
            }
            else if (value == 1)
            {
                ulong mask = (ulong)1 << position;
                ulong result = mask | number;
                Console.WriteLine(result);
            }
        }
    }
}
