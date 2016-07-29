using System;

namespace TriangleSurfaceBySideAndAltitude
{
    class Triangle
    {
        private double side;
        private double height;

        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }


        public Triangle()
        {
            this.side = 0;
            this.height = 0;
        }

        public Triangle(double side, double height)
        {
            this.side = side;
            this.height = height;
        }


        public static void Area(double side, double height)
        {
            double area = 0.5 * (side * height);

            Console.WriteLine("{0:F2}", area);
        }
    }

    class TriangleSurfaceBySA
    {
        static void Main()
        {
            double lenght = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());
            Triangle triangleOne = new Triangle();
            Triangle.Area(lenght, altitude);
        }
    }
}
