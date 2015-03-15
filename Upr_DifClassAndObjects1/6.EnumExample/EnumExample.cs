using System;

public enum DayOfWeek
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
} 

class EnumExample
{
    static void Main(string[] args)
    {
        DayOfWeek day = DayOfWeek.Wednesday;
        Console.WriteLine(day);

        Console.WriteLine((int)day);

        day = DayOfWeek.Friday;
        Console.WriteLine(day);
        Console.WriteLine((int)day);

        Console.WriteLine();
        day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), "Monday");
        Console.WriteLine(day);
    }
}
