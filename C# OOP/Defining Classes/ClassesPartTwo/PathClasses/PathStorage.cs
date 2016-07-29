namespace ClassesPartTwo.PathClasses
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    using PointStructure;
    
    public static class PathStorage
    {
        #region ReadingFile
        public static Path ReadFile(string fileName)
        {
            var output = new Path();

            var fullFile = fileName + ".txt";
            var user = Environment.UserName;
            var path = string.Format($"C:\\Users\\{user}\\Documents\\{fullFile}");

            if (File.Exists(path))
            {
                output = ReadFromFile(path);
            }
            else
            {
                throw new ArgumentException("File not found.");
            }

            return output;
        }

        private static Path ReadFromFile(string path)
        {
            var output = new Path();

            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var coordinates = reader.ReadLine()
                        .Trim()
                        .Split(new char[] { '\\', '.', '[', ']', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x))
                        .ToArray();

                    var newPoint = new Point3D(coordinates[0], coordinates[1], coordinates[2]);

                    output.Add(newPoint);
                }
            }

            return output;
        }
        #endregion
        #region WritingFile
        public static void WriteFile(Path points, string fileName)
        {
            var fullFile = fileName + ".txt";
            var user = Environment.UserName;
            var fileFullPath = string.Format($"C:\\Users\\{user}\\Documents\\{fullFile}");
            
            using (var writer = new StreamWriter(fileFullPath, false, Encoding.UTF8))
            {
                foreach (var point in points)
                {
                    writer.WriteLine(point.ToString());
                }
            }
        }
        #endregion
    }
}
