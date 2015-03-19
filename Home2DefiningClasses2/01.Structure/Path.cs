using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Structure
{
    public class Path
    {
        public const int NumberOfPoints = 100;

        private static Point3D[] sequenceOfPoints;

        public Path()
        {
            sequenceOfPoints = new Point3D[NumberOfPoints];
            for (int i = 0; i < sequenceOfPoints.Length; i++)
            {
                sequenceOfPoints[i] = new Point3D() { XCoord = i, YCoord = -i, ZCoord = i*2};
            }
        }

        public Point3D[] SequenceOfPoints { get; set; }

        public static double PathLength()
        {
            double lengthOfPath = 0;
            for (int i = 1; i < sequenceOfPoints.Length; i++)
            {
                lengthOfPath += Distance.DistanceBetweenTwoPoints(sequenceOfPoints[i - 1], sequenceOfPoints[i]);
            }

            return lengthOfPath;
        }
        
    }
}
