using System;

namespace TriangleThreeSide
{
    class Triangle
    {
        private double sideOne;
        private double sideTwo;
        private double sideThree;

        public double SideOne
        {
            get
            {
                return sideOne;
            }
            set
            {
                sideOne = value;
            }
        }

        public double SideTwo
        {
            get
            {
                return sideTwo;
            }
            set
            {
                sideTwo = value;
            }
        }

        public double SideThree
        {
            get
            {
                return sideThree;
            }
            set
            {
                sideThree = value;
            }
        }
        
        public Triangle()
        {
            this.sideOne = 0;
            this.sideTwo = 0;
            this.sideThree = 0;
        }

        public Triangle(double sideOne, double sideTwo, double sideThree)
        {
            this.sideOne = sideOne;
            this.sideTwo = sideTwo;
            this.sideThree = sideThree;
        }


        public static void Area(double sideOne, double sideTwo, double sideThree)
        {
            double semiPerimeter = (sideOne + sideTwo + sideThree) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideOne) * (semiPerimeter - sideTwo) * (semiPerimeter - sideThree));
            Console.WriteLine("{0:F2}", area);
        }
    }
    class TriangleThreeSide
    {
        static void Main()
        {
            double sideOne = double.Parse(Console.ReadLine());
            double sideTwo = double.Parse(Console.ReadLine());
            double sideThree = double.Parse(Console.ReadLine());

            Triangle.Area(sideOne, sideTwo, sideThree);
            
        }
    }
}
