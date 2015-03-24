using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    public delegate void Repeating(int timeRepeating);

    class Timer
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { 3, 5, 63, 7, 8, 12, 25, 11, 18, 21 };
            Repeating d = delegate(int time)
            {
                while (true)
                {
                    Thread.Sleep(time);
                    Console.WriteLine(string.Join(", ", arr));
                }
            };
            d(3000);
        }
    }
}
