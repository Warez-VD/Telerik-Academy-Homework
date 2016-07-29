namespace SeriesOfLetters
{
    using System;
    using System.Text;

    class SeriesOfLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var result = new StringBuilder();
            char first = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == first)
                {
                    continue;
                }
                else if (input[i] != first)
                {
                    result.Append(first);
                    first = input[i];
                }
            }
            
            result.Append(input[input.Length - 1]);
            Console.WriteLine(result);
        }
    }
}
