namespace WordDictionary
{
    using System;
    using System.Collections.Generic;

    class WordDictionary
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var dict = new Dictionary<string, string>();
            dict.Add(".NET", "platform for applications from Microsoft");
            dict.Add("CLR", "managed execution environment for .NET");
            dict.Add("namespace", "hierarchical organization of classes");

            foreach (var item in dict)
            {
                if (input == item.Key)
                {
                    Console.WriteLine(item.Value);
                }
            }
        }
    }
}
