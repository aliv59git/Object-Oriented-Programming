using System;


namespace _01.Structure
{
    public class Structure
    {
        static void Main(string[] args)
        {
            var point3D = new Point3D() { XCoord = 3.45f, YCoord = 2.12f, ZCoord = 23.22f };
            point3D.Name = "point3D";
            var point = new Point3D() { XCoord = 1.234f, YCoord = 5.123f, ZCoord = 11.345f };
            point.Name = "myPoint";
            Console.WriteLine(point3D.ToString());
            Console.WriteLine(Point3D.StartOfCoordinateSystem);
            Console.WriteLine("The start of coordinate system is point {0} -> {1}", Point3D.StartOfCoordinateSystem.Name, Point3D.StartOfCoordinateSystem);
            Console.WriteLine("MyPoint is {0}", point.ToString());
            Console.WriteLine("The distance from {0} to O(0, 0, 0) is: {1}.", point.Name, Distance.DistanceBetweenTwoPoints(point3D, Point3D.StartOfCoordinateSystem));
            Console.WriteLine("The distance from {0} to point3D is: {1}.", point.Name, Distance.DistanceBetweenTwoPoints(point, point3D));
            Console.WriteLine();
            Path myPath = new Path();
            

        }
    }
}
