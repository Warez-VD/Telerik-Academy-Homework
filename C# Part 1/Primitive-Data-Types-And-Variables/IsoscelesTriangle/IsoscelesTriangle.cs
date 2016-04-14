using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            Console.WriteLine("@".PadLeft(4,' '));
            Console.WriteLine();
            Console.WriteLine("@".PadLeft(3, ' ') + "@".PadLeft(2, ' '));
            Console.WriteLine();
            Console.WriteLine("@".PadLeft(2, ' ') + "@".PadLeft(4, ' '));
            Console.WriteLine();
            Console.WriteLine("@".PadLeft(1, ' ') + "@".PadLeft(2, ' ') + "@".PadLeft(2, ' ') + "@".PadLeft(2, ' '));
        }
    }
}
