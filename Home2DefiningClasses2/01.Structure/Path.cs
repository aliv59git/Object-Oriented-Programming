using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Structure
{
    public class Path
    {
        private List<Point3D> sequenceOfPoints;

        public Path()
        {
            this.sequenceOfPoints = new List<Point3D>();
        }
        
        public List<Point3D> this[int index]
        {
            get
            {
                return this.sequenceOfPoints;
            }
            set { ;}
        }

        public void AddPoins (Point3D point, string name, float xCoord, float yCoord, float zCoord)
        {
            if (this.sequenceOfPoints.Contains(point))
            {
                throw new ArgumentException();
            }
            point.Name = name;
            point.XCoord = xCoord;
            point.YCoord = yCoord;
            point.ZCoord = zCoord;
            this.sequenceOfPoints.Add(point);
        }

        public double PathLength(Path path)
        {
            double lengthOfPath = 0;
            for (int i = 1; i < this.sequenceOfPoints.Count; i++)
            {
                lengthOfPath += Distance.DistanceBetweenTwoPoints(this.sequenceOfPoints[i - 1], this.sequenceOfPoints[i]);
            }

            return lengthOfPath;
        }

        public override string ToString()
        {
            return string.Join(", ", this.sequenceOfPoints);
        }

    }
}
