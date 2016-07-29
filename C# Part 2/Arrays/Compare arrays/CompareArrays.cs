using System;

class CompareArrays
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        bool equal = true;
        int[] arrOne = new int[N];
        int[] arrTwo = new int[N];

        for (int i = 0; i < arrOne.Length; i++)
        {
            arrOne[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arrTwo.Length; i++)
        {
            arrTwo[i] = int.Parse(Console.ReadLine());
        }


        for (int i = 0; i < N; i++)
        {
            if (arrOne[i] == arrTwo[i])
            {
                equal = true;
            }
            else
            {
                equal = false;
                break;
            }
        }

        if (equal)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}

