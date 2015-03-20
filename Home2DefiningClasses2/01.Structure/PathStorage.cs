
namespace _01.Structure
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public static class PathStorage
    {
        public static List<Point3D> sequenceOfPoints;


        //StreamWriter strWriter = new StreamWriter(@"..\..\resPoints.txt");

        static string filePath ="..\\..\\testPoints.txt";
        public static Path ReadPath(string filePath)
        {
            Path path = new Path();
            StreamReader strReader = new StreamReader(filePath);
            string[] lines = strReader.ReadToEnd().Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(new char[] { '(', ',', ')'}, StringSplitOptions.RemoveEmptyEntries);
                string pointName = line[0];
                float xCoord;
                float.TryParse(line[1], out xCoord);
                float yCoord;
                float.TryParse(line[2], out yCoord);
                float zCoord;
                float.TryParse(line[3], out zCoord);
                Point3D point = new Point3D();
                path.AddPoins(point, pointName, xCoord, yCoord, zCoord);
            }
            strReader.Close();
            return path;
        }

        static string filePath1 = "..\\..\\resPoints.txt";
        public static void WritePath(Path path, string filePath1)
        {
            StreamWriter strWriter = new StreamWriter(filePath1);
            int count = path.CountElements(path);
            Console.WriteLine();
            string line = path.ToString();
            int start = 0;
            int end = 0;
            for (int i = 0; i < line.Length; i++)
            {
                char ch = line[i];
                if (char.IsLetter(ch))
                {
                    start = i;
                    end = line.IndexOf(")", i+1);
                    if (end != -1)
                    {
                        string temp = line.Substring(start, end - start + 1);
                        strWriter.WriteLine(temp);
                        i = end + 1;
                    }

                }
                start = 0;
                end = 0;
            }

            strWriter.Close();
            Console.WriteLine("The result of writting can be found in the file ..\\..\\resPoints.txt");
        }
       

    }
}
