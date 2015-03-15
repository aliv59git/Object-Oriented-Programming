using System;
class Rectangle
{
    private float width;
    private float height;

    public Rectangle(float width, float height)
    {
        this.Width = width;
        this.Height = height;
    }

    public float Width
    {
        get { return this.width; }
        set { this.width = value; }
    }
    public float Height
    {
        get { return this.height; }
        set { this.height = value; }
    }

    public float Area
    {
        get { return width * height; }
    }

}
