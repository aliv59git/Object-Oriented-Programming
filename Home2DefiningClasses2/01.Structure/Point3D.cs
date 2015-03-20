using System;


namespace _01.Structure
{
    public struct Point3D
    {
        private static readonly Point3D startOfCordinateSystem;

        public string Name { get; set; }
        public float XCoord { get; set; }
        public float YCoord { get; set; }
        public float ZCoord { get; set; }
        public static Point3D StartOfCoordinateSystem
        {
            get 
            {
                Point3D O = new Point3D() { XCoord = 0.0f, YCoord = 0.0f, ZCoord = 0.0f };
                O.Name = "O";
                return O;
            }
        }

        public override string ToString()
        {
            return string.Format("the point3D: ({0}, {1}, {2})", this.XCoord, this.YCoord, this.ZCoord);
        }

    }
}
