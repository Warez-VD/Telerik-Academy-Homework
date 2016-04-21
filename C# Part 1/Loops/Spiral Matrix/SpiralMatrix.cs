using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        string position = "right";
        int valueRight = -1;
        int valueDown = -1;
        int valueUp = 0;
        int valueTwo = 0;
        matrix[0, 0] = 1;
        int row = 0;
        int col = 0;
        for (int cycle = 2; cycle <= n * n; cycle++)
        {
            if (position == "right")
            {
                matrix[row, ++col] = cycle;
                if (col == n + valueRight)
                {
                    position = "down";
                    valueRight--;
                    continue;
                }
            }
            if (position == "down")
            {
                matrix[++row, col] = cycle;
                if (row == n + valueDown)
                {
                    position = "left";
                    valueDown--;
                    continue;
                }
            }
            if (position == "left")
            {
                matrix[row, --col] = cycle;
                if (col == 0 + valueTwo)
                {
                    valueTwo++;
                    position = "up";
                    continue;
                }
            }
            if (position == "up")
            {
                matrix[--row, col] = cycle;
                if (row == 1 + valueUp)
                {
                    position = "right";
                    valueUp++;
                    continue;
                }
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

