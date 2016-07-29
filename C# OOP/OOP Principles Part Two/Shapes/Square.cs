namespace Shapes
{
    public class Square : Shape
    {
        public Square(double width, double height)
            : base(width, 0)
        {
            base.Height = width;
        }

        public override double CalculateSurface()
        {
            return Width * Width;
        }
    }
}
