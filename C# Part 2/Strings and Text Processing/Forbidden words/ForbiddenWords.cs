namespace ForbiddenWords
{
    using System;
    using System.Linq;
    using System.Text;

    class ForbiddenWords
    {
        static void Main()
        {
            string[] fWords = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x)
                .ToArray();

            string text = Console.ReadLine().Insert(0, " ");
            var result = new StringBuilder();

            int startIndex = 0;
            while (true)
            {
                int startWord = text.IndexOf(' ', startIndex);
                startIndex = startWord + 1;
                int endWord = text.IndexOf(' ', startIndex);
                
                if (endWord < 0)
                {
                    break;
                }
                string compare = text.Substring(startWord, endWord - startWord).Trim(' ');
                
                for (int i = 0; i < fWords.Length; i++)
                {
                    if (fWords[i] == compare)
                    {
                        string replace = string.Empty;
                        for (int j = 0; j < fWords[i].Length; j++)
                        {
                            replace += '*';
                        }
                        compare = compare.Replace(compare, replace);
                    }
                }
                result.Append(compare + " ");
            }

            int lastInterval = text.LastIndexOf(' ');
            int lastSymbol = text.LastIndexOf('.');
            string lastWord = text.Substring(lastInterval, lastSymbol - lastInterval).Trim(' ');
            for (int i = 0; i < fWords.Length; i++)
            {
                if (fWords[i] == lastWord)
                {
                    string replace = string.Empty;
                    for (int j = 0; j < fWords[i].Length; j++)
                    {
                        replace += '*';
                    }
                    lastWord = lastWord.Replace(lastWord, replace);
                }
            }
            result.Append(lastWord + ".");

            Console.WriteLine(result);
        }
    }
}
