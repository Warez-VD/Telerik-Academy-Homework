namespace ClassesPartTwo.PathClasses
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    using PointStructure;

    public class Path : IEnumerable<Point3D>
    {
        private List<Point3D> points;

        public Path()
        {
            points = new List<Point3D>();
        }

        public int Count
        {
            get
            {
                return this.points.Count;
            }
        }

        public int Capacity
        {
            get
            {
                return this.points.Capacity;
            }
        }

        public void Add(Point3D point)
        {
            this.points.Add(point);
        }

        public void Remove(Point3D point)
        {
            this.points.Remove(point);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            for (int i = 0; i < points.Count; i++)
            {
                result.AppendLine(points[i].ToString());
            }

            result.Remove(result.Length - 1, 1);

            return result.ToString();
        }

        public IEnumerator<Point3D> GetEnumerator()
        {
            return points.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return points.GetEnumerator();
        }
    }
}
