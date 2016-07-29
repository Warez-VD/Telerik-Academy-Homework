using System;

class IndexOfLetters
{
    static void Main()
    {
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            Console.WriteLine(word[i] - 'a');
        }
    }
}

