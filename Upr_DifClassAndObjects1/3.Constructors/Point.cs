using System;
class Point
{
    private int xCoord;
    private int yCoord;
    private string name;

    public Point()
    {
    }

    public Point(int xCoord, int yCoord, string name)
    {
        this.xCoord = xCoord;
        this.yCoord = yCoord;
        this.name = string.Format("Point ({0}, {1})", xCoord, yCoord);
    }

    public int XCoord
    {
        get { return this.xCoord; }
        set { this.xCoord = value; }
    }
    public int YCoord { get; set; }

    public string Name { get; set; } 

}
