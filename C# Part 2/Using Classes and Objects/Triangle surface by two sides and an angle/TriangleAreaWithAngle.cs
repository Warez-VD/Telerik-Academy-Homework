using System;

namespace TriangleAreaWithAngle
{
    class Triangle
    {
        private double sideOne;
        private double sideTwo;
        private double angle;

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

        public double Angle
        {
            get
            {
                return angle;
            }
            set
            {
                angle = value;
            }
        }

        public Triangle()
        {
            this.sideOne = 0;
            this.sideTwo = 0;
            this.angle = 0;
        }

        public Triangle(double sideOne, double sideTwo, double angle)
        {
            this.sideOne = sideOne;
            this.sideTwo = sideTwo;
            this.angle = angle;
        }


        public static void Area(double sideOne, double sideTwo, double angle)
        {
            double degree = Math.PI * angle / 180.0;
            double area = ((sideOne * sideTwo) / 2) * Math.Sin(degree);
            Console.WriteLine("{0:F2}", area);
        }
    }
    class TriangleAreaWithAngle
    {

        static void Main()
        {
            double sideOne = double.Parse(Console.ReadLine());
            double sideTwo = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());

            Triangle.Area(sideOne, sideTwo, angle);
        }
    }
}
