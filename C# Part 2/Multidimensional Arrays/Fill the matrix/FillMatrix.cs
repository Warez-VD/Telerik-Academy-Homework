using System;

class FillMatrix
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());
        int[,] matrix = new int[N, N];
        int counter = 0;

        if (symbol == 'a')
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = ++counter;
                }
            }

            PrintMatrix(matrix);
        }
        else if (symbol == 'b')
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = ++counter;
                    }
                }
                else if (col % 2 == 1)
                {
                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                    {
                        matrix[row, col] = ++counter;
                    }
                }
            }

            PrintMatrix(matrix);
        }
        else if (symbol == 'c')
        {
            for (int row = N - 1; row >= 0; row--)
            {
                for (int col = 0; col < N - row; col++)
                {
                    matrix[row + col, col] = ++counter;
                }
            }
            for (int col = 1; col < N; col++)
            {
                for (int row = 0; row < N - col; row++)
                {
                    matrix[row, col + row] = ++counter;
                }
            }
            PrintMatrix(matrix);
        }
        else if (symbol == 'd')
        {
            string position = "down";
            matrix[0, 0] = 1;
            int rightValue = -1;
            int leftValue = 0;
            int upValue = 0;
            int downValue = -1;
            int row = 0;
            int col = 0;
            for (int cycle = 2; cycle <= N * N; cycle++)
            {
                if (position == "down")
                {
                    matrix[++row, col] = cycle;
                    if (row == N + downValue)
                    {
                        position = "right";
                        downValue--;
                        continue;
                    }
                }
                else if (position == "right")
                {
                    matrix[row, ++col] = cycle;
                    if (col == N + rightValue)
                    {
                        position = "up";
                        rightValue--;
                        continue;
                    }
                }
                else if (position == "up")
                {
                    matrix[--row, col] = cycle;
                    if (row == 0 + upValue)
                    {
                        position = "left";
                        upValue++;
                        continue;
                    }
                }
                else if (position == "left")
                {
                    matrix[row, --col] = cycle;
                    if (col == 1 + leftValue)
                    {
                        position = "down";
                        leftValue++;
                        continue;
                    }
                }
            }
            PrintMatrix(matrix);
        }
    }

    public static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col == matrix.GetLength(1) - 1)
                {
                    Console.Write("{0}", matrix[row, col]);
                }
                else
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
            }
            Console.WriteLine();
        }
    }
}

