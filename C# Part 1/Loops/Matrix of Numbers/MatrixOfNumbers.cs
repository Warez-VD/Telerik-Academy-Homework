using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //int counter = 0;
        //if (1 <= n && n <= 20)
        //{
        //    for (int row = 1; row <= n; row++)
        //    {
        //        for (int col = 1; col <= n; col++)
        //        {
        //            console.write("{0} ", col + counter);
        //        }
        //        counter++;
        //        console.writeline();
        //    }
        //}
        int[] matrix = new int[n];
        int counter = 0;
        for (int row = 0; row < n; row++)
        {
            for (int col = 1; col <= n; col++)
            {
                matrix[row] = col + counter; ;
                Console.Write(" " + matrix[row]);
            }
            counter++;
            Console.WriteLine();
        }
    }
}

