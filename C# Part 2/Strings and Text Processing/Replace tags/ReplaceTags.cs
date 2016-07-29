namespace ReplaceTags
{
    using System;
    using System.Text;

    class ReplaceTags
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var words = input.Split(new[] { "<a href=\"", "</a>" }, StringSplitOptions.None);
            var result = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains("\">"))
                {
                    var replaced = words[i].Split(new[] { "\">" }, StringSplitOptions.None);
                    var temp = replaced[0];
                    replaced[0] = replaced[1];
                    replaced[1] = temp;
                    result.Append(string.Format("[{0}]({1})", replaced[0], replaced[1]));
                }
                else
                {
                    result.Append(words[i]);
                }
            }

            Console.WriteLine(result.ToString().Trim());
        }
    }
}
