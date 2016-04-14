using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongSequence
{
    class LongSequence
    {
        static void Main()
        {
            for (int i = 2; i < 1002; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}", i);
                }
                else
                {
                    Console.WriteLine("-{0}", i);
                }
            }
        }
    }
}
