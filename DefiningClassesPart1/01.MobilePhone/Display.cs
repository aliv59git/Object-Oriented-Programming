using System;

namespace _01.MobilePhone
{

    public class Display
    {
        private int numberOfColors;
        private float size;

        public Display()
        {
        }
        public Display(float size)
        {
            this.Size = size;
        }

        public Display(int numberOfColors, float size)
        {
            this.NumberOfColors = numberOfColors;
            this.Size = size;
        }

        public int NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value <= 0 || value > int.MaxValue)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.numberOfColors = value;
            }
        }

        public float Size
        {
            get { return this.size; }
            set
            {
                if (value < 2.54f || value > 25.4f)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.size = value;
            }
        }

    }
}
