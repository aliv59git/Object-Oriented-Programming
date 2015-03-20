﻿using System;
using System.IO;


namespace _01.Structure
{
    public class Structure
    {
        static void Main(string[] args)
        {
            var point3D = new Point3D() { Name="P", XCoord = 3.45f, YCoord = 2.12f, ZCoord = 23.22f };
            var point = new Point3D() { Name="A", XCoord = 1.234f, YCoord = 5.123f, ZCoord = 11.345f };
            Console.WriteLine("{0}", point3D.ToString());
            Console.WriteLine("{0}", Point3D.O);
            Console.WriteLine("The start of coordinate system is point {0}", Point3D.O);
            Console.WriteLine("MyPoint is {0}", point.ToString());
            Console.WriteLine("Other point is {0}", point3D);
            Console.WriteLine("The distance from {0} to {1} is: {2}.", point.Name, Point3D.O, Distance.DistanceBetweenTwoPoints(point3D, Point3D.O));
            Console.WriteLine("The distance from {0} to {1} is: {2}.", point.Name, point3D.Name, Distance.DistanceBetweenTwoPoints(point, point3D));
            Console.WriteLine();

            Path myPath = new Path();
            myPath.ToString();
            myPath.AddPoins(point, "A", 1f, 1f, 1f);
            myPath.AddPoins(point, "B", 2f, 2f, 2f);
            Console.WriteLine(myPath.PathLength(myPath));
            myPath.AddPoins(point, "C", 3f, 3f, 3f);
            myPath.AddPoins(point, "D", 12.73f, -3.6f, 5.4f);
            myPath.AddPoins(point, "E", 22.73f, 3.6f, -5.4f);
            myPath.AddPoins(point, "F", 32.73f, 3.6f, -5.4f);
            Console.WriteLine();

            double pathLength = myPath.PathLength(myPath);
            Console.WriteLine("My path is: "+ myPath.ToString());
            Console.WriteLine("The length of this path is: "+pathLength);
            Console.WriteLine();

            Path myPath1 = new Path();
            int count = 51;
            for (int i = 0; i < count; i++)
            {
                myPath1.AddPoins(point, "P" + i, i*2, i*3+5, -i * 2+11 );
            }
            Console.WriteLine("The length of path {0} is: {1}", myPath1.ToString(), myPath1.PathLength(myPath1));





        }
    }
}
