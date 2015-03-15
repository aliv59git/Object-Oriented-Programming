using System;
public class Constants
{
    public const double PI = 3.1415926535897932385;
    public readonly double Size;
    //constructor
    public Constants(int size)
    {
        this.Size = size;
    }



    static void Main(string[] args)
    {
        Console.WriteLine(Constants.PI);
        Constants c = new Constants(300000);
        Constants dou = new Constants(2345);
        Console.WriteLine(c.Size + " Dve Constanti otliavo i otdiasno " + dou.Size);
        Console.WriteLine(c.Size);
        Console.WriteLine(dou.Size);
    }
}
