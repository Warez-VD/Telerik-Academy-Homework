using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdBit
{
    class ThirdBit
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int position = 3;
            int mask = 1 << position;
            int nAndMask = number & mask;
            int bit = nAndMask >> position;
            Console.WriteLine(bit);
        }
    }
}
