using System;
using System.Globalization;

namespace DateInBulgarian
{
    class DateInBulgarian
    {
        public static void Main()
        {
            DateTime date = ReadDateFromTheConsole();
            DateTime newDate = AddTime(date, 6, 30);
            PrintDate(newDate, new CultureInfo("bg-BG"));
        }

        public static DateTime AddTime(DateTime date, int hours, int minutes = 0, int seconds = 0)
        {
            return date.AddHours(hours)
                .AddMinutes(minutes)
                .AddSeconds(seconds);
        }

        public static DateTime ReadDateFromTheConsole()
        {
            DateTime date;
            if (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                throw new FormatException("Input was not in the correct format.");
            }

            return date;
        }

        public static void PrintDate(DateTime date, CultureInfo culture)
        {
            Console.WriteLine("{0:dd.MM.yyyy H:mm:ss} {1}", date, date.ToString("dddd", culture));
        }

    }
}
