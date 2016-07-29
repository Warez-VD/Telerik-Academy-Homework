using System;

class SelectionSort
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int[] arrayOne = new int[N];

        for (int i = 0; i < arrayOne.Length; i++)
        {
            arrayOne[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arrayOne.Length - 1; i++)
        {
            int iMin = i;
            int temp;
            for (int j = i + 1; j < arrayOne.Length; j++)
            {
                if (arrayOne[j] < arrayOne[iMin])
                {
                    iMin = j;
                }
            }

            if (iMin != i)
            {
                temp = arrayOne[i];
                arrayOne[i] = arrayOne[iMin];
                arrayOne[iMin] = temp;
            }
        }

        for (int i = 0; i < arrayOne.Length; i++)
        {
            Console.WriteLine(arrayOne[i]);
        }
    }
}

