using System;

class FindSumInArray
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int S = int.Parse(Console.ReadLine());

        int[] array = new int[N];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int currentSum = 0;
        int startIndex = 0;
        int endIndex = 0;
        int a = 0;
        int b = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (currentSum < S)
            {
                currentSum += array[i];
                endIndex = i;
            }

            if(currentSum > S)
            {
                currentSum = array[i];
                startIndex = i;
            }
            else if (currentSum == S)
            {
                a = startIndex;
                b = endIndex;
                break;
            }

        }
        if (b != 0)
        {
            for (int i = a; i <= b; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
        else
        {
            Console.Write("Does not present");
        }
        Console.WriteLine();
    }
}

