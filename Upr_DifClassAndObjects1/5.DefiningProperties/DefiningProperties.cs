using System;
class DefiningProperties
{
    static void Main(string[] args)
    {
        Rectangle firstRectangle = new Rectangle(0.345f, 3.456f);
        Console.WriteLine("First Rectangle has width: {0}, height: {1} and area: {2}", 
            firstRectangle.Width, firstRectangle.Height, firstRectangle.Area);

        Console.WriteLine();
        Rectangle secondRectangle = new Rectangle(12.234f, 23.123f);
        Console.WriteLine("Second Rectangle has width: {0}, height: {1} and Area: {2}", 
            secondRectangle.Width, secondRectangle.Height, secondRectangle.Area);
        Console.WriteLine();

        UserProfile newUser = new UserProfile(18119876, "Ivan", "Draganov");
        Console.WriteLine(newUser);
    }
}
