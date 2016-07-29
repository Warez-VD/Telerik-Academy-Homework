using System;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        string input = Console.ReadLine();

        int[] inputNums = input
            .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        int N = inputNums[0];
        int M = inputNums[1];
        
        int[,] matrix = ReadMatrix(N, M);

        int max = 0;
        bool hasMax = false;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int value = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                    + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                    + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (!hasMax)
                {
                    max = value;
                    hasMax = true;
                }
                else if (value > max)
                {
                    max = value;
                }
            }
        }
        Console.WriteLine(max);
    }


    public static int[,] ReadMatrix(int N, int M)
    {
        int[] temp;
        int[,] matrix = new int[N, M];
        for (int row = 0; row < N; row++)
        {
            temp = Console.ReadLine()
                .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            for (int col = 0; col < M; col++)
            {
                matrix[row, col] = temp[col];
            }
        }
        return matrix;
    }
}

