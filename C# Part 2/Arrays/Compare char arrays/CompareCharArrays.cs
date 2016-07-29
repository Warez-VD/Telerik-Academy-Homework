using System;

class CompareCharArrays
{
    static void Main()
    {
        string arrOne = Console.ReadLine();
        string arrTwo = Console.ReadLine();

        bool equal = true;
        string result = string.Empty;

        if (arrOne.Length != arrTwo.Length)
        {
            equal = false;
            result = (arrOne.Length < arrTwo.Length) ? "<" : ">";
        }
        else
        {
            for (int i = 0; i < arrOne.Length; i++)
            {
                if (arrOne[i] != arrTwo[i])
                {
                    equal = false;
                    result = (arrOne[i] < arrTwo[i]) ? "<" : ">";
                    break;
                }
            }
        }

        Console.WriteLine(equal ? "=" : result);
    }
}

