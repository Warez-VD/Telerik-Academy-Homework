using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool prime = true;
            if (number > 0 && number <= 100)
            {
                for (int divider = 2; divider <= Math.Sqrt(number); divider++)
                {
                    if (number % divider == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine(prime ? "true" : "false");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
