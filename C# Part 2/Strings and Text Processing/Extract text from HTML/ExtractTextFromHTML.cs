namespace ExtractTextFromHTML
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ExtractTextFromHTML
    {
        static void Main(string[] args)
        {
            
            bool openedTag = false;
            var result = new StringBuilder();
            string title = string.Empty;
            for (int j = 0; j < 7; j++)
            {
                string text = Console.ReadLine().Trim();
                if (text.Contains("title"))
                {
                    int indexOfTitle = text.IndexOf("title");
                    int lenghtOfTitle = indexOfTitle + 6;
                    int indexOfCloseTagAfterTitle = text.IndexOf('<', indexOfTitle);
                    title = text.Substring(lenghtOfTitle, indexOfCloseTagAfterTitle - lenghtOfTitle);
                }
                
                for (int i = 0; i < text.Length; i++)
                {
                    char currentCharacter = text[i];
                    if (currentCharacter == '<')
                    {
                        openedTag = true;
                    }
                    else if (currentCharacter == '>')
                    {
                        openedTag = false;
                        result.Append(' ');
                        continue;
                    }
                    
                    if (!openedTag)
                    {
                        result.Append(currentCharacter);
                    }

                    if (i == text.Length - 1)
                    {
                        result.Append(' ');
                    }
                }
            }

            string final = result.ToString().Replace(title, "").TrimStart();
            Console.WriteLine("Title: {0}", title);
            Console.WriteLine("Text: {0}", final);
        }
    }
}
