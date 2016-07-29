using System;

class MergeSort
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] numbers = new int[N];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        numbers = SplitArray(numbers);

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    public static int[] SplitArray(int[] arr)
    {
        if (arr.Length == 1)
        {
            return arr;
        }

        int middle = arr.Length / 2;
        int[] leftArr = new int[middle];
        int[] rigthArr = new int[arr.Length - middle];

        for (int i = 0; i < arr.Length; i++)
        {
            if (i < middle)
            {
                leftArr[i] = arr[i];
            }
            else
            {
                rigthArr[i - middle] = arr[i];
            }
        }

        leftArr = SplitArray(leftArr);
        rigthArr = SplitArray(rigthArr);

        return MergeArrays(leftArr, rigthArr);
    }

    public static int[] MergeArrays(int[] left, int[] right)
    {
        int leftIndex = 0;
        int rightIndex = 0;
        int[] arr = new int[left.Length + right.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            if (rightIndex == right.Length
                || (leftIndex < left.Length
                && left[leftIndex] <= right[rightIndex]))
            {
                arr[i] = left[leftIndex];
                leftIndex++;
            }
            else if (leftIndex == left.Length
                || (rightIndex < right.Length
                && left[leftIndex] >= right[rightIndex]))
            {
                arr[i] = right[rightIndex];
                rightIndex++;
            }
        }

        return arr;
    }
}

