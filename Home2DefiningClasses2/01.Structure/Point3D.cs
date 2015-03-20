using System;


namespace _01.Structure
{
    public struct Point3D
    {
        private static readonly Point3D startOfCordinateSystem;

        //public Point3D(string name, float xCoord, float yCoord, float zCoord)
        //{
        //    this.Name = name;
        //    this.XCoord = xCoord;
        //    this.YCoord = yCoord;
        //    this.ZCoord = zCoord;
        //}


        public string Name { get; set; }
        public float XCoord { get; set; }
        public float YCoord { get; set; }
        public float ZCoord { get; set; }
        public static Point3D O
        {
            get 
            {
                Point3D O = new Point3D() { Name= "O", XCoord = 0.0f, YCoord = 0.0f, ZCoord = 0.0f };
                return O;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}({1}, {2}, {3})", this.Name, this.XCoord, this.YCoord, this.ZCoord);
        }

    }
}
