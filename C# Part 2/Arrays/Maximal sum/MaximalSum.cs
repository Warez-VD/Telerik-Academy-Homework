using System;

class MaximalSum
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }


        int currentSum = array[0];
        int maxSum = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (currentSum < 0)
            {
                currentSum = array[i];
            }
            else
            {
                currentSum += array[i];
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }

        Console.WriteLine(maxSum);
    }
}

