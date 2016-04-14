using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatingNumbers
{
    class FormatingNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            if (a >= 0 && a <= 500)
            {
                Console.WriteLine("{0,-10:X}|{1}|{2,10:0.00}|{3,-10:0.000}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
            }
        }
    }
}
