using System;

class BinarySearch
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        int index = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int X = int.Parse(Console.ReadLine());

        Array.Sort(array);
        int right = array.Length - 1;

        for (int i = 0; i <= right;)
        {
            int middle = (i + right) / 2;
            if (array[middle] == X)
            {
                index = middle;
                break;
            }
            else if (array[middle] > X)
            {
                right = middle - 1;
            }
            else if(array[middle] < X)
            {
                i = middle + 1;
            }
        }
        if (index == int.MinValue)
        {
            index = -1;
        }
        Console.WriteLine(index);
    }
}

