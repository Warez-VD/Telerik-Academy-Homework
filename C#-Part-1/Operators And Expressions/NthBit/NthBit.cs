using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthBit
{
    class NthBit
    {
        static void Main()
        {
            long p = long.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            long mask = 1 << (int)n;
            long pAndMask = p & mask;
            long bit = pAndMask >> n;
            Console.WriteLine(bit);
        }
    }
}
