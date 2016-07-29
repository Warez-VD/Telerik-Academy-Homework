using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace DateFromTextInCanada
{
    class DateFromTextInCanada
    {
        static void Main()
        {
            //DateTime.TryParseExact(input, "DD.MM.YYYY", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
            //Console.WriteLine(date);

            string input = Console.ReadLine();
            var result = new List<string>();
            DateTime date;

            
            input = input.Insert(0, " ");
            while (true)
            {
                int startIndex = 0;
                int start = input.IndexOf(' ', startIndex);
                startIndex = start + 1;
                int endIndex = input.IndexOf(' ', startIndex);
                if (endIndex < 0)
                {
                    break;
                }
                string word = input.Substring(start, endIndex - start).TrimStart(' ');
                if (DateTime.TryParse(word, out date))
                {
                    result.Add(word);
                }
                input = input.Remove(start, endIndex - start);
            }

            if (DateTime.TryParse(input, out date))
            {
                result.Add(input.Trim(new char[] { ' ', ',', '.'}));
            }
            string dateStr = string.Empty;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
            for (int i = 0; i < result.Count; i++)
            {
                date = DateTime.ParseExact(result[i],"YYYY.MM.DD", CultureInfo.InvariantCulture);
                Console.Write(date);
            }
            
        }
    }
}
