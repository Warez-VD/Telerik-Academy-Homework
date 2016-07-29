namespace ClassesPartTwo.PointClass
{
    using System;

    using PointStructure;

    static class PointDist
    {
        public static double PointDistance(Point3D a, Point3D b)
        {
            double distance = double.MinValue;

            double distanceX = Math.Pow((a.X - b.X), 2);
            double distanceY = Math.Pow((a.Y - b.Y), 2);
            double distanceZ = Math.Pow((a.Z - b.Z), 2);
            distance = Math.Sqrt(distanceX + distanceY + distanceZ);

            return distance;
        }
    }
}
