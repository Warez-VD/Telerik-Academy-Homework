using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCircleRectangle
{
    class CircleRectangle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double circleX = 1;
            double circleY = 1;
            double radius = 1.5;
            double distance = Math.Sqrt(Math.Pow((x - circleX), 2) + Math.Pow((y - circleY), 2));
            bool isInCircle = distance <= radius;
            bool isInRectangle = (x >= -1) && (x <= 5) && (y >= -1) && (y <= 1);

            if (isInCircle == true && isInRectangle == false)
            {
                Console.WriteLine("inside circle outside rectangle");
            }
            else if (isInCircle == false && isInRectangle == true)
            {
                Console.WriteLine("outside circle inside rectangle");
            }
            else if (isInCircle == true && isInRectangle == true)
            {
                Console.WriteLine("inside circle inside rectangle");
            }
            else
            {
                Console.WriteLine("outside circle outside rectangle");
            }
        }
    }
}
