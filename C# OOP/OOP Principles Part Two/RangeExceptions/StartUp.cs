namespace RangeExceptions
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            try
            {
                if (number < 1 || number > 100)
                {
                    throw new InvalidRangeException<int>("Number must be in range 1 - 100", 1, 100);
                }

                Console.WriteLine(number);
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Write("Enter date: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            try
            {
                if (date < new DateTime(1980, 1, 1) || date > new DateTime(2013, 12, 31))
                {
                    throw new InvalidRangeException<DateTime>("Date must be in range 1.1.1980 - 31.12.2013", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
                }

                Console.WriteLine(date);
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
