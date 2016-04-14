using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevideBySevenAndFive
{
    class Divide
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine("true {0}", number);
            }
            else
            {
                Console.WriteLine("false {0}", number);
            }
        }
    }
}
