using System;
class PointExample
{
    private int xCoord;
    private int yCoord;

    public PointExample(int xCoord, int yCoord)
    {
        this.xCoord = xCoord;
        this.yCoord = yCoord;
    }

    public int XCoord { get; set; }

    public int YCoord { get; set; }

    public double DistanceToPoint(PointExample p)
    {
        return Math.Sqrt((p.xCoord - this.xCoord) * (p.xCoord - this.xCoord) + 
            (p.yCoord - this.yCoord)*(p.yCoord - this.yCoord));
    }

}
