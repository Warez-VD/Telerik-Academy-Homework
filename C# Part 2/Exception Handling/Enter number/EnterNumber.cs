namespace EnterNumber
{
    using System;
    using System.Text;

    class EnterNumber
    {
        static int ReadNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());
            if (start > number && number > end)
            {
                throw new FormatException();
            }
            return number;
        }

        static void Main()
        {
            int[] numbers = new int[12];
            numbers[0] = 1;
            numbers[11] = 100;
            var result = new StringBuilder();

            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    numbers[i] = ReadNumber(1, 100);   
                }

                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] <= numbers[i - 1])
                    {
                        throw new FormatException();
                    }
                }

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    result.Append(numbers[i] + " < ");
                }
                result.Append(numbers[numbers.Length - 1]);
                Console.WriteLine(result);
            }
            catch(FormatException)
            {
                Console.WriteLine("Exception");
            }
            
        }
    }
}
