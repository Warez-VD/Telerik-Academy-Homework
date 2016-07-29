namespace DateDifference
{
    using System;
    using System.Globalization;

    class DateDifference
    {
        static void Main()
        {
            string dateOne = Console.ReadLine();
            DateTime firstDate = DateTime.ParseExact(dateOne, "d.MM.yyyy", CultureInfo.InvariantCulture);
            string dateTwo = Console.ReadLine();
            DateTime secondDate = DateTime.ParseExact(dateTwo, "d.MM.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(Math.Abs((secondDate - firstDate).TotalDays));
        }
    }
}
