using System;

namespace _1.Shapes
{
    public class Rectangle : Shape
    {

        public override double CalculateSurface()
        {
            return this.Height *  this.Width;
        }
    }
}
