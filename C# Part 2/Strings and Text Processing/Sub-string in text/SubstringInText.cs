namespace SubstringInText
{
    using System;
    using System.IO;
    using System.Collections.Generic;

    class SubstringInText
    {
        static void Main()
        {
            short[] inputBuffer = new short[4096];
            Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
            Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));
            string word = Console.ReadLine().ToLower();
            string input = Console.ReadLine().ToLower();
            var indexes = new List<int>();
            int index = 0;
            while (true)
            {
                int found = input.IndexOf(word, index);
                if (found < 0)
                {
                    break;
                }

                indexes.Add(found);

                index = found + 1;
            }
            Console.WriteLine(indexes.Count);
        }
    }
}
