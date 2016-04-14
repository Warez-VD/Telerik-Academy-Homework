using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInACircle
{
    class PointInCircle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double circleX = 0;
            double circleY = 0;
            double radius = 2;
            double distance = Math.Sqrt(Math.Pow((x - circleX),2) + Math.Pow((y - circleY), 2));
            if (distance <= radius)
            {
                Console.WriteLine("yes {0:0.00}", distance);
            }
            else
            {
                Console.WriteLine("no {0:0.00}", distance);
            }
        }
    }
}
