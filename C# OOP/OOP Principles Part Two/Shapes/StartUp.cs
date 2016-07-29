namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        static void Main()
        {
            IShape[] shapes = 
            {
                new Square(2.5, 6),
                new Triangle(2, 8),
                new Rectangle(15, 6)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.GetType().Name} surface: {shape.CalculateSurface()}");
            }
        }
    }
}
