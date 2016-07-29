using System;
using System.Linq;

class Sequence
{
    static int bestCount = 0;
    static string[,] matrix;
    static void Main()
    {
        string input = Console.ReadLine();

        int[] inputNums = input
            .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        int N = inputNums[0];
        int M = inputNums[1];
        ReadMatrix(N, M);
        

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                CheckForSeq(matrix, row, col);
            }
        }
        
        Console.WriteLine(bestCount);

    }

    public static void ReadMatrix(int n, int m)
    {
        string[] temp;
        matrix = new string[n, m];
        for (int row = 0; row < n; row++)
        {
            temp = Console.ReadLine()
                .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x)
                .ToArray();

            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = temp[col];
            }
        }
        
    }


    public static void CheckForSeq(string[,] matrix, int row, int col)
    {
        int diagonal = DiagonalSearch(matrix, row, col);
        int column = ColumnSearch(matrix, row, col);
        int rowS = RowSearch(matrix, row, col);
        int otherDiag = OtherDiagonal(matrix, row, col);

        if (diagonal > bestCount ||
            rowS > bestCount ||
            column > bestCount ||
            otherDiag > bestCount)
        {
            bestCount = Math.Max(Math.Max(Math.Max (rowS, column), diagonal),otherDiag);
        }
    }


    public static int ColumnSearch(string[,] matrix, int row, int col)
    {
        int counter = 0;
        string firstElement = matrix[row, col];

        for (int i = row; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, col] == firstElement)
            {
                ++counter;
            }
            else
            {
                break;
            }
        }
        return counter;
    }


    public static int RowSearch(string[,] matrix, int row, int col)
    {
        int counter = 0;
        string firstElement = matrix[row, col];

        for (int i = col; i < matrix.GetLength(1); i++)
        {
            if (matrix[row, i] == firstElement)
            {
                ++counter;
            }
            else
            {
                break;
            }
        }

        return counter;
    }


    public static int DiagonalSearch(string[,] matrix, int row, int col)
    {
        int counter = 0;
        string element = matrix[row, col];

        for (int i = row, j = col; i < matrix.GetLength(0) && j < matrix.GetLength(1); i++, j++)
        {
            if (matrix[i, j] == element)
            {
                ++counter;
            }
            else
            {
                break;
            }
        }

        return counter;
    }


    public static int OtherDiagonal(string[,] matrix, int row, int col)
    {
        int counter = 0;
        string element = matrix[row, col];

        for (int i = matrix.GetLength(0) - 2, j = matrix.GetLength(0) - 2; i >= row ; i--, j--)
        {
            if (matrix[i + 1, j] == matrix[i, j + 1])
            {
                counter++;
            }
        }

        return counter;
    }
}

