namespace SquareRoot
{
    using System;

    class SquareRoot
    {
        static double SquareR(double num)
        {
            double result = 0;

            if (num < 0)
            {
                throw new FormatException();
            }
            else
            {
                result = Math.Sqrt(num);
            }

            return result;
        }

        static void Main()
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", SquareR(number));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
