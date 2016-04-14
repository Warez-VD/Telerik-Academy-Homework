using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main()
        {
            double weightW = double.Parse(Console.ReadLine());
            double weightMoon = weightW * 0.17;
            Console.WriteLine("{0:0.000}", weightMoon);
        }
    }
}
