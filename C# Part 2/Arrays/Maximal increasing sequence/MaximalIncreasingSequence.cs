using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        int countSeq = 1;
        int maxSeq = int.MinValue;

        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < N - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                countSeq++;
            }
            else
            {
                countSeq = 1;
            }

            if (countSeq >= maxSeq)
            {
                maxSeq = countSeq;
            }
        }
        Console.WriteLine(maxSeq);
    }
}

