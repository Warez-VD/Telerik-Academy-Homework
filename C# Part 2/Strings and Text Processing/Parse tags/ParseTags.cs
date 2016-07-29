namespace ParseTags
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;
    class ParseTags
    {
        static void Main()
        {
            string text = Console.ReadLine();
            // match and print
            Console.WriteLine(Regex.Replace(text, "<upcase>(.*?)</upcase>", word => word.Groups[1].Value.ToUpper()));
            //short[] inputBuffer = new short[10000];
            //Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
            //Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));
            //string input = Console.ReadLine();
            //input = input.Replace("\\", " ")
            //             .Replace("\"", " ");
            //string[] sentences = input.Split(new[] { '<', '>' }, StringSplitOptions.RemoveEmptyEntries);
            //List<string> sent = new List<string>(sentences);
            //for (int i = 0; i < sent.Count; i++)
            //{
            //    if (sent[i] == "upcase")
            //    {
            //        sent[i + 1] = sent[i + 1].ToUpper();
            //        sent.Remove(sent[i]);
            //    }
            //    else if (sent[i] == "/upcase")
            //    {
            //        sent.Remove(sent[i]);
            //    }
            //}

            //foreach (var item in sent)
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine();
        }
    }
}
