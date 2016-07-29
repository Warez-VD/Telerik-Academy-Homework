namespace ReverseSentence
{
    using System;
    using System.Text;

    class ReverseSentence
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ',' || input[i] == '.')
                {
                    input = input.Insert(i, " ");
                    break;
                }
            }

            while (true)
            {
                int startIndex = input.Length - 1;
                int endIndex = input.LastIndexOf(' ');
                if (endIndex < 0)
                {
                    break;
                }
                string word = input.Substring(endIndex, startIndex - endIndex).TrimStart(' ');
                result.Append(word + " ");
                input = input.Remove(endIndex, startIndex - endIndex);
            }

            for (int i = 0; i < input.Length; i++)
            {
                result.Append(input[i]);
            }

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == ',' || result[i] == '.')
                {
                    result = result.Remove(i - 1, 1);
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
