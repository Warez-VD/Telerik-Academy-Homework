using System;

class QuickSort
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] numbers = new int[N];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        ArraySort(numbers, 0, numbers.Length - 1);

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
    public static void ArraySort(int[] arr, int start, int end)
    {

        int pivotIndex = (start + end) / 2;
        int leftIndex = start;
        int rightindex = end;
        int pivot = arr[pivotIndex];

        while (leftIndex <= rightindex)
        {
            while (arr[leftIndex] < pivot)
            {
                leftIndex++;
            }

            while (arr[rightindex] > pivot)
            {
                rightindex--;
            }

            if (leftIndex <= rightindex)
            {
                int temp = arr[leftIndex];
                arr[leftIndex] = arr[rightindex];
                arr[rightindex] = temp;
                leftIndex++;
                rightindex--;
            }

            if (start < rightindex)
            {
                ArraySort(arr, start, rightindex);
            }

            if (leftIndex < end)
            {
                ArraySort(arr, leftIndex, end);
            }
        }
    }
}

