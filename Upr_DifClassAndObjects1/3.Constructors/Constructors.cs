using System;
class Constructors
{
    static void Main(string[] args)
    {
        Person anonymus = new Person();
        Console.WriteLine("Person {0} has age {1}", anonymus.Name ?? "[unnamed]", anonymus.Age);
        Console.WriteLine();

        Person Pesho = new Person("Pesho Ivanov Tzvetanov", 19);
        Console.WriteLine("Person {0} has age {1}", Pesho.Name, Pesho.Age);
        Console.WriteLine(new string('-', 49));

        AlarmClock defaultAlarm = new AlarmClock();
        Console.WriteLine("Wake up! Wake up! I's {0:D2}:{1:D2} o'clock!", defaultAlarm.Hours, defaultAlarm.Minutes);
        Console.WriteLine(new string('-', 49));

        AlarmClock earlyAlarm = new AlarmClock(5, 37);
        Console.WriteLine("Wake up! Wake up! I's {0:D2}:{1:D2} o'clock!", earlyAlarm.Hours, earlyAlarm.Minutes);
        Console.WriteLine(new string('-', 49));

        Point zeroPoint = new Point(0, 0, "Ivan");
        zeroPoint.Name = "\"Center of the coordinate system\"";
        Point myPoint = new Point(7, 17, "Mypoint");
        myPoint.Name = "\"My coordinate now\"";
        Console.WriteLine("Center of the coordinate system is Point({0}, {1}) and it's called {2}. We are now at myPoint({3}, {4}) with name {5}", 
            zeroPoint.XCoord, zeroPoint.YCoord, zeroPoint.Name, myPoint.XCoord, myPoint.YCoord, myPoint.Name);

        Console.WriteLine(myPoint.Name);
        Point newPoint = new Point();
        Console.WriteLine(newPoint.Name);
        Console.WriteLine(newPoint.XCoord);
    }
}
