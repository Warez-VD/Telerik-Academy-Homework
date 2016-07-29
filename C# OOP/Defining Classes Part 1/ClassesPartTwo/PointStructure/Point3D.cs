namespace ClassesPartTwo.PointStructure
{
    using System.Text;

    public struct Point3D
    {
        private static readonly Point3D pointO = new Point3D(0, 0, 0);

        //Constructor
        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        //Properties
        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public static Point3D O
        {
            get
            {
                return pointO;
            }
        }

        //Method
        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append($"[{this.X}, {this.Y}, {this.Z}]");

            return result.ToString();
        }
    }
}
