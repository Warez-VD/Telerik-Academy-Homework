using System;

class RemoveElements
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        int[] arrayValue = new int[N];

        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            arrayValue[i] = 1;
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[j] <= array[i] && arrayValue[j] + 1 > arrayValue[i])
                {
                    arrayValue[i] = arrayValue[j] + 1;
                }
            }
        }

        Array.Sort(arrayValue);
        int result = arrayValue.Length - arrayValue[arrayValue.Length - 1];
        Console.WriteLine(result);
    }
}

