using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GenericList
{
    public class GenericList<T> where T : IComparable
    {
        public const int DefaultCapacity = 32;
        private T[] elements;
        private int index;

        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
            this.index = 0;
        }
        public GenericList() : this(DefaultCapacity)
        {
        }

        public void Add(T element)
        {
            this.elements[this.index] = element;
            this.index++;
        }

        public T this[int index]
        {
            get
            {
                return this.elements[index];
            }
            set
            {
                if (index < 0 || index >= this.elements.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.elements[index] = value;
            }
        }
        public int Index
        {
            get
            {
                return this.index;
            }
        }

        public int IndexOf(T element)
        {
            int index = -1;
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        
        public void Remove(T element)
        {
            int index = IndexOf(element);
            this.elements[index] = default(T);
            for (int i = index; i < this.elements.Length-1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
        }



    }
}

//      public int IndexOf(T element)
//        {
//            int index = -1;

//            for (int ind = 0; ind <= this.lastInd; ind++)
//            {
//                if (this.list[ind].Equals(element))
//                {
//                    index = ind;
//                    break;
//                }
//            }

//            return index;
//        }

//        public void Clear()
//        {
//            for (int ind = 0; ind <= this.lastInd; ind++)
//            {
//                this.list[ind] = default(T);
//            }

//            this.lastInd = -1;
//        }

//        private void DoubleListSize()
//        {
//            int newSize = (this.list.Length == 0) ? 2 : this.list.Length * 2;

//            T[] newList = new T[newSize];
//            for (int ind = 0; ind <= this.lastInd; ind++)
//            {
//                newList[ind] = this.list[ind];
//            }

//            this.list = newList;
//        }

//        private void CheckRange(int index)
//        {
//            if (index < 0 || index > this.lastInd)
//            {
//                throw new IndexOutOfRangeException();
//            }
//        }

//        public override string ToString()
//        {
//            StringBuilder result = new StringBuilder();

//            for (int ind = 0; ind <= this.lastInd; ind++)
//            {
//                result.AppendLine(String.Format("{0,-5}{1}", String.Format("[{0}]", ind), this.list[ind]));
//            }

//            return result.ToString().Trim();
//        }
