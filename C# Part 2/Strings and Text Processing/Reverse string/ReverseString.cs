namespace ReverseString
{
    using System;
    using System.Text;
    
    class ReverseString
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var result = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                result.Append(input[i]);
            }

            Console.WriteLine(result);
        }
    }
}
