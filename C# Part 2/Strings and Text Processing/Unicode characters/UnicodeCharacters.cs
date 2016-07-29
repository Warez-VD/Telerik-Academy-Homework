namespace UnicodeCharacters
{
    using System;
    using System.Text;

    class UnicodeCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                result.Append("\\u");
                result.Append(string.Format("{0:X4}", (int)input[i]));
            }
            Console.WriteLine(result);
        }
    }
}
