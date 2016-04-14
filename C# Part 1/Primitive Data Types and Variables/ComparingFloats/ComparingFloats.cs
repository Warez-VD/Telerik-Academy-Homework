using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double biggestNumber = Math.Max(firstNumber, secondNumber);
            double minimalNumber = Math.Min(firstNumber, secondNumber);
            double result = biggestNumber - minimalNumber;
            double eps = 0.000001;
            if (result < eps)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
