using System;


namespace _1.Shapes
{
    public class Circle : Shape
    {
        public Circle(double width)
            : this()
        {
            this.Width = width;
            this.Height = width;
        }
        public Circle()
            : base()
        {
        }

        public override double CalculateSurface()
        {
            return Math.PI * Width * Width;
        }
    }
}
