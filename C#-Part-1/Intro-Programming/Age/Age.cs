using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Age
    {
        static void Main()
        {
            DateTime birthDate = DateTime.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            int ageYearNow = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.Month > birthDate.Month)
            {
                ageYearNow = DateTime.Now.Year - birthDate.Year;
            }
            else if(DateTime.Now.Month < birthDate.Month)
            {
                ageYearNow = DateTime.Now.Year - birthDate.Year - 1;
            }
            else
            {
                if (DateTime.Now.Day >= birthDate.Day)
                {
                    ageYearNow = DateTime.Now.Year - birthDate.Year;
                }
                else
                {
                    ageYearNow = DateTime.Now.Year - birthDate.Year - 1;
                }
            }

            int ageAfterTenYears = ageYearNow + 10;
            Console.WriteLine(ageYearNow);
            Console.WriteLine(ageAfterTenYears);
        }
    }
}
