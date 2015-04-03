using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace _3.BitArray
{
    public class BitArray : IEnumerable<int>, IComparable
    {
        public BitArray(ulong number)
        {
            this.Number = number;
        }
        public ulong Number { get; set; }

        public int this[int position]
        {
            get
            {
                if (position < 0 || position > 63)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return ((int)this.Number >> position) & 1;
            }
            set
            {
                if (position < 0 || position > 63)
                {
                    throw new ArgumentException();
                }
                if ((value != 1) && (value != 0))
                {
                    throw new ArgumentOutOfRangeException();
                }
                if ((((int)this.Number >> position) & 1) != value)
                {
                    this.Number ^= (ulong)(1 << position);
                }
            }
        }


        public override bool Equals(object obj)
        {
            return this.Number.Equals(obj as BitArray);
        }
        public static bool operator ==(BitArray numb1, BitArray numb2)
        {
            return numb1.Equals(numb2);
        }

        public static bool operator !=(BitArray numb1, BitArray numb2)
        {
            return !(numb1.Equals(numb2));
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 63; i >=0; i--)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int CompareTo(object obj)
        {
            return this.Number.CompareTo((obj as BitArray).Number);
        }

    }
}
