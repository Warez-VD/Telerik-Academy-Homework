namespace ExtractSentences
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    class ExtractSentences
    {
        static void Main()
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();
            var sentences = text.Split('.');

            var result = new StringBuilder();

            foreach (var sentence in sentences)
            {
                var words = sentence.Split(new[] { ' ', '.', ',', '1', '2', '3', '4', '5', '6', '7', '8', '9'}, StringSplitOptions.RemoveEmptyEntries);

                if (Array.IndexOf(words, word) > -1)
                {
                    result.Append(sentence.Trim());
                    result.Append(". ");
                }
            }

            Console.WriteLine(result.ToString().Trim());
        }
    }
    //using System;
    //using System.Collections.Generic;
    //using System.Text;

    //class ExtractSentences
    //{
    //    static void Main()
    //    {
    //        string word = Console.ReadLine();
    //        var text = Console.ReadLine().Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
    //        var result = new StringBuilder();

    //        var wordSeparators = new List<char>();
    //        for (int i = 0; i < text.Length; i++)
    //        {
    //            var currentSentence = text[i];
    //            for (int j = 0; j < currentSentence.Length; j++)
    //            {
    //                if (!(char.IsLetter(currentSentence[j])))
    //                {
    //                    wordSeparators.Add(currentSentence[j]);
    //                }
    //            }
    //        }

    //        for (int i = 0; i < text.Length; i++)
    //        {
    //            var currentSentece = text[i].Split(wordSeparators.ToArray(), StringSplitOptions.RemoveEmptyEntries);
    //            bool equals = false;
    //            foreach (var item in currentSentece)
    //            {
    //                if (item.Equals(word))
    //                {
    //                    equals = true;
    //                    break;
    //                }
    //            }
    //            if (equals)
    //            {
    //                result.Append(text[i] + ".");
    //            }
    //        }

    //        Console.WriteLine(result);
    //    }
    //}
}
