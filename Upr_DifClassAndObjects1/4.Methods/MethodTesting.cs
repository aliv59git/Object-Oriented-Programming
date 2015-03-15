using System;
class MethodTesting
{
    static void Main(string[] args)
    {
        PointExample p1 = new PointExample(0, 0);
        PointExample p2 = new PointExample(3, 4);
        Console.WriteLine("Distance between p1 and p2 is {0}", p1.DistanceToPoint(p2));
    }
}
