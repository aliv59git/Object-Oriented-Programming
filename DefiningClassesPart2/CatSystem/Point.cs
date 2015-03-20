using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatSystem
{
    public struct Point
    {
        public float X { get; set; }
        public float Y { get; set; }

        public string GetCoordinates()
        {
            return string.Format("{0}, {1}", this.X, this.Y);
        }


    }
}
