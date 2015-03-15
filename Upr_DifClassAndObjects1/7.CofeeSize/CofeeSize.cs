using System;

public enum CoffeeSize
{
    Small = 100, Normal = 150, Double = 300
}

public class Coffee
{
    public CoffeeSize size;

    public Coffee(CoffeeSize size)
    {
        this.size = size;
    }

    public CoffeeSize Size
    {
        get{ return this.size; }
    }

}


class CofeeSize
{
    static void Main(string[] args)
    {
        Coffee normalCoffee = new Coffee(CoffeeSize.Normal);
        Console.WriteLine("The {0} coffee is {1} ml.", normalCoffee.Size, (int)normalCoffee.Size);

        Coffee doubleCoffee = new Coffee(CoffeeSize.Double);
        Console.WriteLine("The {0} coffee is {1} ml.", doubleCoffee.Size, (int)doubleCoffee.Size);

    }
}
