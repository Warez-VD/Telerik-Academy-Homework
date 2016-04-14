using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigits
{
    class FourDigits
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int firstDigit = number % 10;
            int secondDigit = (number / 10) % 10;
            int thirdDigit = (number / 100) % 10;
            int fourthDigit = (number / 1000) % 10;
            int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
            Console.WriteLine("{0}{1}{2}{3}", firstDigit, fourthDigit, thirdDigit, secondDigit);
            Console.WriteLine("{0}{1}{2}{3}", fourthDigit, secondDigit, thirdDigit, firstDigit);
        }
    }
}
