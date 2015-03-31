using System;
using System.Collections.Generic;
using System.Linq;


namespace _3.RangeExceptions
{
    public class InvalidRangeException<T> : ApplicationException
        where T: IComparable<T>
    {
        public T start;
        public T end;

        public InvalidRangeException(string msg, T start, T end, Exception ex)
            : base(String.Format("{0} must be in range [{1}; {2}]", msg, start, end), ex)
        {
            this.Start = start;
            this.End = end;
        }
        

        public InvalidRangeException(string msg, T start, T end)
            :this(msg, start, end, null)
        {
        }

        public InvalidRangeException(T start, T end)
            : this(null, start, end, null)
        {
        }
        public InvalidRangeException()
        {
        }

        public T Start
        {
            get { return this.start; }
            set { this.start = value; }
        }

        public T End
        {
            get { return this.end; }
            set { this.end = value; }
        }


    }
}
