namespace ClassesPartTwo
{
    using System;

    using Generics;
    using Matrix;
    using PathClasses;
    using PointStructure;
    using PointClass;
    using Version;

    [Version(2, 11)]
    class MainProgram
    {
        static void Main()
        {
            //Test Task 1 - 3 PointStructure
            Point3D point = new Point3D(1, 2, 3);
            Console.WriteLine("Point distance {0:F2}", PointDist.PointDistance(point, Point3D.O));

            //Test Task 4 Writing and reading file
            Path points = new Path();
            points.Add(Point3D.O);
            points.Add(point);
            PathStorage.WriteFile(points, "MyPoints");
            Path newPoints = PathStorage.ReadFile("MyPoints");
            Console.WriteLine(newPoints);

            //Test Task 5 - 7 Generic Class
            GenericList<int> myList = new GenericList<int>(15);
            myList.Add(15);
            myList.Add(12);
            myList.Add(130);

            myList.RemoveAt(2);
            myList.Insert(0, 123);

            //myList.Clear();
            Console.WriteLine($"Index: {myList.Find(123)}");
            Console.WriteLine($"Max: {myList.Max()}");
            Console.WriteLine($"Max: {myList.Min()}");

            //Test Task 8 - 10 Generic Matrix
            //Task 8
            Matrix<int> matrix = new Matrix<int>(2, 3);

            //Task 9
            int increasingNumber = 1;
            for (int row = 0; row < matrix.GetLenght(0); row++)
            {
                for (int col = 0; col < matrix.GetLenght(1); col++)
                {
                    matrix[row, col] = increasingNumber;
                    increasingNumber++;
                }
            }

            //Task 10
            var matrixTwo = new Matrix<int>(3, 1);
            matrixTwo[0, 0] = 2;
            matrixTwo[1, 0] = 3;
            matrixTwo[2, 0] = 4;
            Console.WriteLine("Multiplication");
            Console.WriteLine(matrix * matrixTwo);

            var matrixTestOne = new Matrix<int>(2, 2);
            matrixTestOne[0, 0] = 2;
            matrixTestOne[0, 1] = 3;
            matrixTestOne[1, 0] = 4;
            matrixTestOne[1, 1] = 5;
            
            var matrixTestTwo = new Matrix<int>(2, 2);
            matrixTestTwo[0, 0] = 2;
            matrixTestTwo[0, 1] = 33;
            matrixTestTwo[1, 0] = 41;
            matrixTestTwo[1, 1] = 10;
            Console.WriteLine("Addition");
            Console.WriteLine(matrixTestOne + matrixTestTwo);
            Console.WriteLine("Substraction");
            Console.WriteLine(matrixTestOne - matrixTestTwo);

            //Test Task 11 Attribute
            var versionAtt = typeof(MainProgram).GetCustomAttributes(false);
            foreach (var att in versionAtt)
            {
                var versionAttr = (VersionAttribute)att;
                Console.WriteLine("Version: {0}", versionAttr.Version);
            }
        }
    }
}
